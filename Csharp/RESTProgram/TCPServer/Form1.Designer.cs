namespace TCPServer
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
            this.ShowMsg = new System.Windows.Forms.TextBox();
            this.Inputtext = new System.Windows.Forms.TextBox();
            this.LogMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowMsg
            // 
            this.ShowMsg.Location = new System.Drawing.Point(12, 26);
            this.ShowMsg.Multiline = true;
            this.ShowMsg.Name = "ShowMsg";
            this.ShowMsg.Size = new System.Drawing.Size(532, 175);
            this.ShowMsg.TabIndex = 0;
            // 
            // Inputtext
            // 
            this.Inputtext.Location = new System.Drawing.Point(12, 207);
            this.Inputtext.Name = "Inputtext";
            this.Inputtext.Size = new System.Drawing.Size(532, 21);
            this.Inputtext.TabIndex = 1;
            this.Inputtext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // LogMsg
            // 
            this.LogMsg.Location = new System.Drawing.Point(12, 234);
            this.LogMsg.Multiline = true;
            this.LogMsg.Name = "LogMsg";
            this.LogMsg.Size = new System.Drawing.Size(532, 105);
            this.LogMsg.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 351);
            this.Controls.Add(this.LogMsg);
            this.Controls.Add(this.Inputtext);
            this.Controls.Add(this.ShowMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ShowMsg;
        private System.Windows.Forms.TextBox Inputtext;
        private System.Windows.Forms.TextBox LogMsg;
    }
}

