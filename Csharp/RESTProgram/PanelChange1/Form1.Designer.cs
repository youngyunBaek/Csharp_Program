namespace PanelChange1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPage1Next_Click = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPage2Pre_Click = new System.Windows.Forms.Button();
            this.btnPage2Next_Click = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPage3Pre_Click = new System.Windows.Forms.Button();
            this.btnPage3Next_Click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "첫번째 페이지";
            // 
            // btnPage1Next_Click
            // 
            this.btnPage1Next_Click.Location = new System.Drawing.Point(295, 197);
            this.btnPage1Next_Click.Name = "btnPage1Next_Click";
            this.btnPage1Next_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPage1Next_Click.TabIndex = 1;
            this.btnPage1Next_Click.Text = "다음";
            this.btnPage1Next_Click.UseVisualStyleBackColor = true;
            this.btnPage1Next_Click.Click += new System.EventHandler(this.btnPage1Next_Click_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPage2Next_Click);
            this.panel1.Controls.Add(this.btnPage2Pre_Click);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 232);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "두번째 페이지";
            // 
            // btnPage2Pre_Click
            // 
            this.btnPage2Pre_Click.Location = new System.Drawing.Point(12, 197);
            this.btnPage2Pre_Click.Name = "btnPage2Pre_Click";
            this.btnPage2Pre_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPage2Pre_Click.TabIndex = 1;
            this.btnPage2Pre_Click.Text = "이전";
            this.btnPage2Pre_Click.UseVisualStyleBackColor = true;
            this.btnPage2Pre_Click.Click += new System.EventHandler(this.btnPage2Pre_Click_Click);
            // 
            // btnPage2Next_Click
            // 
            this.btnPage2Next_Click.Location = new System.Drawing.Point(295, 197);
            this.btnPage2Next_Click.Name = "btnPage2Next_Click";
            this.btnPage2Next_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPage2Next_Click.TabIndex = 2;
            this.btnPage2Next_Click.Text = "다음";
            this.btnPage2Next_Click.UseVisualStyleBackColor = true;
            this.btnPage2Next_Click.Click += new System.EventHandler(this.btnPage2Next_Click_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPage3Next_Click);
            this.panel2.Controls.Add(this.btnPage3Pre_Click);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 232);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "세번재 페이지";
            // 
            // btnPage3Pre_Click
            // 
            this.btnPage3Pre_Click.Location = new System.Drawing.Point(12, 197);
            this.btnPage3Pre_Click.Name = "btnPage3Pre_Click";
            this.btnPage3Pre_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPage3Pre_Click.TabIndex = 1;
            this.btnPage3Pre_Click.Text = "이전";
            this.btnPage3Pre_Click.UseVisualStyleBackColor = true;
            this.btnPage3Pre_Click.Click += new System.EventHandler(this.btnPage3Pre_Click_Click);
            // 
            // btnPage3Next_Click
            // 
            this.btnPage3Next_Click.Location = new System.Drawing.Point(295, 197);
            this.btnPage3Next_Click.Name = "btnPage3Next_Click";
            this.btnPage3Next_Click.Size = new System.Drawing.Size(75, 23);
            this.btnPage3Next_Click.TabIndex = 2;
            this.btnPage3Next_Click.Text = "다음";
            this.btnPage3Next_Click.UseVisualStyleBackColor = true;
            this.btnPage3Next_Click.Click += new System.EventHandler(this.btnPage3Next_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 232);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPage1Next_Click);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPage1Next_Click;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPage2Next_Click;
        private System.Windows.Forms.Button btnPage2Pre_Click;
        private System.Windows.Forms.Button btnPage3Next_Click;
        private System.Windows.Forms.Button btnPage3Pre_Click;
        private System.Windows.Forms.Label label3;
    }
}

