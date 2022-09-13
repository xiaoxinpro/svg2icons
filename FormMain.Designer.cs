namespace svg2icons
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonOutput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckedListBoxDPI = new System.Windows.Forms.CheckedListBox();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入SVG：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInput.Location = new System.Drawing.Point(65, 9);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(267, 21);
            this.TextBoxInput.TabIndex = 1;
            // 
            // ButtonOutput
            // 
            this.ButtonOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOutput.Location = new System.Drawing.Point(338, 125);
            this.ButtonOutput.Name = "ButtonOutput";
            this.ButtonOutput.Size = new System.Drawing.Size(75, 27);
            this.ButtonOutput.TabIndex = 2;
            this.ButtonOutput.Text = "输出";
            this.ButtonOutput.UseVisualStyleBackColor = true;
            this.ButtonOutput.Click += new System.EventHandler(this.ButtonOutput_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "分辨率：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckedListBoxDPI
            // 
            this.CheckedListBoxDPI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckedListBoxDPI.FormattingEnabled = true;
            this.CheckedListBoxDPI.Location = new System.Drawing.Point(65, 36);
            this.CheckedListBoxDPI.Name = "CheckedListBoxDPI";
            this.CheckedListBoxDPI.Size = new System.Drawing.Size(267, 116);
            this.CheckedListBoxDPI.TabIndex = 3;
            // 
            // ButtonInput
            // 
            this.ButtonInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonInput.Location = new System.Drawing.Point(338, 8);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(75, 23);
            this.ButtonInput.TabIndex = 4;
            this.ButtonInput.Text = "选择";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 168);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.CheckedListBoxDPI);
            this.Controls.Add(this.ButtonOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVG转多分辨率ICO图标";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox CheckedListBoxDPI;
        private System.Windows.Forms.Button ButtonInput;
    }
}

