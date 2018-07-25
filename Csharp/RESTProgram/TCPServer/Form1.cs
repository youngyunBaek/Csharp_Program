using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        #region Variable declaration

        // Size of receive buffer.
        public const int BufferSize = 1024;

        // Receive buffer.받을 버퍼
        public byte[] buffer = new byte[BufferSize];

        // Received data string.
        private Socket m_server; // Server Sokcet
        private Socket sbSock;   // Server Async Callback Socket
        private Socket workSocke;

        //출력용 dele
        delegate void DelMsg(string strMsg);
        #endregion       

        public Form1()
        {
            InitializeComponent();
            //this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetLogMsg("Socket Loading....");
            m_server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iep = new IPEndPoint(IPAddress.Any, 9090);
            SetLogMsg("Socket Bind...");
            m_server.Bind(iep);
            m_server.Listen(10);
            m_server.BeginAccept(new AsyncCallback(AcceptConn), m_server);
            SetLogMsg("Socket Load End");
        }

        protected void AcceptConn(IAsyncResult iar)
        {
            Socket _oldserver = (Socket)iar.AsyncState;
            workSocke = _oldserver.EndAccept(iar);
            SetLogMsg(workSocke.RemoteEndPoint.ToString() + "의 연결 요청 수락");
            string strWelcome = "서버 메세지 welcome to my server";
            //string to byte
            byte[] Message = Encoding.UTF8.GetBytes(strWelcome);

            //핸드세이딩용. 안해도 무방하지만 해라
            workSocke.BeginSend(Message, 0, Message.Length, SocketFlags.None,
                new AsyncCallback(SendData), workSocke);

            //리시브 활성화 중요!!! 리시브용 버퍼를 따로 사용해야합니다 혼용될경우 메세지 누락.
            workSocke.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
                new AsyncCallback(ReceiveData), workSocke);
        }

        //SendCallback
        /*----------------------*
        * ##### CallBack #####    *
        *      SendCallback         *
        *----------------------*/       

        private void SendData(IAsyncResult iar)
        {
            Socket _Client = (Socket)iar.AsyncState;
            int sent = _Client.EndSend(iar);
        }

        //ReceiveCallback
        /*----------------------*
        * ##### CallBack #####    *
        *          Receive         *
        *----------------------*/

        private void ReceiveData(IAsyncResult iar)
        {
            Socket _Client = (Socket)iar.AsyncState;
            //강제로 Client 종료시 프로그램 Die를 방지하기 위하여 try catch문을 사용
            try
            {
                int nRecvSize = _Client.EndReceive(iar);

                if (nRecvSize <= 0)
                {
                    _Client.Close();
                    SetLogMsg("연결요청 대기중...");
                    m_server.BeginAccept(new AsyncCallback(AcceptConn), m_server);
                    return;
                }
                string recvData = Encoding.UTF8.GetString(buffer, 0, nRecvSize);
                SetShowMsg("[받음]" + recvData);

                //주석 풀었음
                _Client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
                    new AsyncCallback(ReceiveData), _Client);
            }
            catch (Exception ex)
            {
                _Client.Close();
                SetLogMsg("연결요청 대기중...");
                m_server.BeginAccept(new AsyncCallback(AcceptConn), m_server);
            }
        }

        private void SetShowMsg(string _strMsg)
        {
            if (ShowMsg.InvokeRequired)
            {
                DelMsg _call = new DelMsg(SetShowMsg);
                this.Invoke(_call, _strMsg);
            }
            else
            {
                ShowMsg.AppendText(_strMsg + "\n[" + DateTime.Now.ToString() + "]\n");
                ShowMsg.ScrollToCaret();
            }
        }

        private void SetLogMsg(string _strMsg)
        {
            if (LogMsg.InvokeRequired)
            {
                DelMsg _call = new DelMsg(SetLogMsg);
                this.Invoke(_call, _strMsg);
            }
            else
            {
                LogMsg.AppendText("[" + DateTime.Now.ToString() + "] " + _strMsg + "\n");
                LogMsg.ScrollToCaret();
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Enter && workSocke != null)
            {
                byte[] message = Encoding.UTF8.GetBytes(Inputtext.Text);
                SetShowMsg("[서버] " + Inputtext.Text.ToString());
                Inputtext.Clear();
                workSocke.BeginSend(message, 0, message.Length, SocketFlags.None,
                    new AsyncCallback(SendData), workSocke);
            }
        }
    }
}
