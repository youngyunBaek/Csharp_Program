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

namespace TCPClient
{
    public partial class Form1 : Form
    {
        #region 변수
        private Socket m_Client; //Receive
        private Socket cbSocket; //Send
        public const int bufferSize = 1024;
        private byte[] buffer = new byte[bufferSize];
        delegate void DsetRichText(string data);
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strIP = text_ip.Text.ToString();
            string strPORT = text_port.Text.ToString();
            int iPORT = Convert.ToInt32(strPORT.ToString());

            SetLogMsg(strIP.ToString() + ":" + strPORT.ToString() + " 접속중...\n");
            m_Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //IPE생성
            IPEndPoint iep = new IPEndPoint(IPAddress.Parse(strIP), iPORT);
            m_Client.BeginConnect(iep, new AsyncCallback(Connected), m_Client);
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (m_Client != null)
            {
                m_Client.Close();
                m_Client = null;
                SetLogMsg("접속종료\n");
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void Connected(IAsyncResult iar)
        {
            cbSocket = (Socket)iar.AsyncState;
            try
            {
                cbSocket.EndConnect(iar);
                string temp = cbSocket.RemoteEndPoint.ToString() + "에 연결 완료\n";
                SetLogMsg(temp);
                cbSocket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None,
                    new AsyncCallback(ReceiveData), cbSocket);
            }
            catch (SocketException)
            {
                SetLogMsg("연결 실패\n");
            }
        }

        private void ReceiveData(IAsyncResult iar)
        {
            cbSocket = (Socket)iar.AsyncState;
            try
            {
                int recv = cbSocket.EndReceive(iar);
                if (recv == 0) return;
                string stringData = Encoding.UTF8.GetString(buffer, 0, recv);
                SetShowMsg(stringData + "\n");
                //수정중
                cbSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None,
                    new AsyncCallback(ReceiveData), cbSocket);

            }
            catch (Exception ex)
            {
                cbSocket.Close();
                SetShowMsg("강제종료" + "\n");
            }
        }

        private void SendData(IAsyncResult iar)
        {
            string strSendData = (string)iar.AsyncState;
            SetShowMsg(strSendData + "\n");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_Client != null)
            {
                m_Client.Close();
            }
        }

        private void SetLogMsg(string strLogMsg)
        {
            if (LogMsg.InvokeRequired)
            {
                DsetRichText _call = new DsetRichText(SetLogMsg);
                this.Invoke(_call, strLogMsg);
            }
            else
            {
                LogMsg.AppendText("[" + DateTime.Now.ToString() + "] " + strLogMsg);
                LogMsg.ScrollToCaret();
            }
        }

        private void SetShowMsg(string strShowMsg)
        {
            if (ShowMsg.InvokeRequired)
            {
                DsetRichText _call = new DsetRichText(SetShowMsg);
                this.Invoke(_call, strShowMsg);
            }
            else
            {
                ShowMsg.AppendText("[" + DateTime.Now.ToString() + "] " + strShowMsg);
                ShowMsg.ScrollToCaret();
            }
        }

        private void InSertkey_KeyDown(object sender, KeyEventArgs e)
        {
            //Send Data
            if (e.KeyData == Keys.Enter && m_Client != null)
            {
                byte[] message = Encoding.UTF8.GetBytes(InSertkey.Text);
                string strSend = InSertkey.Text.ToString();
                InSertkey.Clear();
                //서버와는 다른 방법으로 string을 전달해 봤다 그냥 공부하는겹 해봤다..
                m_Client.BeginSend(message, 0, message.Length, SocketFlags.None,
                    new AsyncCallback(SendData), strSend);
            }
        }
    }
}
