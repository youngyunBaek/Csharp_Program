namespace TCPClient
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.text_port = new System.Windows.Forms.TextBox();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowMsg = new System.Windows.Forms.TextBox();
            this.InSertkey = new System.Windows.Forms.TextBox();
            this.LogMsg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.text_port);
            this.groupBox1.Controls.Add(this.text_ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "접속상태::";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Unconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(467, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_port
            // 
            this.text_port.Location = new System.Drawing.Point(63, 59);
            this.text_port.Name = "text_port";
            this.text_port.Size = new System.Drawing.Size(292, 21);
            this.text_port.TabIndex = 3;
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(63, 25);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(292, 21);
            this.text_ip.TabIndex = 2;
            this.text_ip.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // ShowMsg
            // 
            this.ShowMsg.Location = new System.Drawing.Point(12, 110);
            this.ShowMsg.Multiline = true;
            this.ShowMsg.Name = "ShowMsg";
            this.ShowMsg.Size = new System.Drawing.Size(548, 241);
            this.ShowMsg.TabIndex = 1;
            // 
            // InSertkey
            // 
            this.InSertkey.Location = new System.Drawing.Point(12, 357);
            this.InSertkey.Name = "InSertkey";
            this.InSertkey.Size = new System.Drawing.Size(548, 21);
            this.InSertkey.TabIndex = 2;
            this.InSertkey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InSertkey_KeyDown);
            // 
            // LogMsg
            // 
            this.LogMsg.Location = new System.Drawing.Point(12, 384);
            this.LogMsg.Multiline = true;
            this.LogMsg.Name = "LogMsg";
            this.LogMsg.Size = new System.Drawing.Size(548, 139);
            this.LogMsg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 535);
            this.Controls.Add(this.LogMsg);
            this.Controls.Add(this.InSertkey);
            this.Controls.Add(this.ShowMsg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text_port;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ShowMsg;
        private System.Windows.Forms.TextBox InSertkey;
        private System.Windows.Forms.TextBox LogMsg;
    }
}

