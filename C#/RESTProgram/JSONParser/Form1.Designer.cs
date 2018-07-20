namespace JSONParser
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.cmdDeserialise = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDebugOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Raw JSON (Serialised String)";
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(6, 20);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(604, 94);
            this.txtInput.TabIndex = 0;
            // 
            // cmdDeserialise
            // 
            this.cmdDeserialise.Location = new System.Drawing.Point(12, 138);
            this.cmdDeserialise.Name = "cmdDeserialise";
            this.cmdDeserialise.Size = new System.Drawing.Size(91, 23);
            this.cmdDeserialise.TabIndex = 1;
            this.cmdDeserialise.Text = "Deserialise";
            this.cmdDeserialise.UseVisualStyleBackColor = true;
            this.cmdDeserialise.Click += new System.EventHandler(this.cmdDeserialise_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(109, 138);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(102, 23);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear Debug";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDebugOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(616, 141);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Output";
            // 
            // txtDebugOutput
            // 
            this.txtDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugOutput.Location = new System.Drawing.Point(6, 20);
            this.txtDebugOutput.Multiline = true;
            this.txtDebugOutput.Name = "txtDebugOutput";
            this.txtDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugOutput.Size = new System.Drawing.Size(604, 115);
            this.txtDebugOutput.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdDeserialise);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "JSON Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdDeserialise;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtDebugOutput;
    }
}

