namespace des
{
    partial class aesjia
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyLabel = new System.Windows.Forms.Label();
            this.radioBtn3 = new System.Windows.Forms.RadioButton();
            this.radioBtn2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.DecryptionBtn = new System.Windows.Forms.Button();
            this.EncryptionBtn = new System.Windows.Forms.Button();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.CipherLabel = new System.Windows.Forms.Label();
            this.PlainText = new System.Windows.Forms.TextBox();
            this.PlianLabel = new System.Windows.Forms.Label();
            this.KeyText = new System.Windows.Forms.TextBox();
            this.KeyBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(11, 131);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(77, 12);
            this.KeyLabel.TabIndex = 34;
            this.KeyLabel.Text = "请输入密钥：";
            // 
            // radioBtn3
            // 
            this.radioBtn3.AutoSize = true;
            this.radioBtn3.Location = new System.Drawing.Point(150, 3);
            this.radioBtn3.Name = "radioBtn3";
            this.radioBtn3.Size = new System.Drawing.Size(65, 16);
            this.radioBtn3.TabIndex = 2;
            this.radioBtn3.Text = "256bits";
            this.radioBtn3.UseVisualStyleBackColor = true;
            // 
            // radioBtn2
            // 
            this.radioBtn2.AutoSize = true;
            this.radioBtn2.Location = new System.Drawing.Point(79, 3);
            this.radioBtn2.Name = "radioBtn2";
            this.radioBtn2.Size = new System.Drawing.Size(65, 16);
            this.radioBtn2.TabIndex = 1;
            this.radioBtn2.Text = "192bits";
            this.radioBtn2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioBtn3);
            this.panel1.Controls.Add(this.radioBtn2);
            this.panel1.Controls.Add(this.radioBtn1);
            this.panel1.Location = new System.Drawing.Point(120, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 26);
            this.panel1.TabIndex = 26;
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.Checked = true;
            this.radioBtn1.Location = new System.Drawing.Point(8, 3);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(65, 16);
            this.radioBtn1.TabIndex = 0;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "128bits";
            this.radioBtn1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 44;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(461, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "导出";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 21);
            this.textBox1.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 47;
            this.button2.Text = "打开解密文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "打开加密文件";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 22;
            this.label1.Text = "请选择密钥长度:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(15, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 53);
            this.panel3.TabIndex = 45;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(460, 554);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 50;
            this.button4.Text = "导出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // DecryptionBtn
            // 
            this.DecryptionBtn.Location = new System.Drawing.Point(452, 128);
            this.DecryptionBtn.Name = "DecryptionBtn";
            this.DecryptionBtn.Size = new System.Drawing.Size(73, 23);
            this.DecryptionBtn.TabIndex = 42;
            this.DecryptionBtn.Text = "解密";
            this.DecryptionBtn.UseVisualStyleBackColor = true;
            this.DecryptionBtn.Click += new System.EventHandler(this.DecryptionBtn_Click_1);
            // 
            // EncryptionBtn
            // 
            this.EncryptionBtn.Location = new System.Drawing.Point(371, 128);
            this.EncryptionBtn.Name = "EncryptionBtn";
            this.EncryptionBtn.Size = new System.Drawing.Size(75, 23);
            this.EncryptionBtn.TabIndex = 41;
            this.EncryptionBtn.Text = "加密";
            this.EncryptionBtn.UseVisualStyleBackColor = true;
            this.EncryptionBtn.Click += new System.EventHandler(this.EncryptionBtn_Click_1);
            // 
            // CipherText
            // 
            this.CipherText.AllowDrop = true;
            this.CipherText.Location = new System.Drawing.Point(11, 398);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CipherText.Size = new System.Drawing.Size(525, 150);
            this.CipherText.TabIndex = 40;
            // 
            // CipherLabel
            // 
            this.CipherLabel.AutoSize = true;
            this.CipherLabel.Location = new System.Drawing.Point(11, 383);
            this.CipherLabel.Name = "CipherLabel";
            this.CipherLabel.Size = new System.Drawing.Size(35, 12);
            this.CipherLabel.TabIndex = 39;
            this.CipherLabel.Text = "密文:";
            // 
            // PlainText
            // 
            this.PlainText.AllowDrop = true;
            this.PlainText.Location = new System.Drawing.Point(11, 203);
            this.PlainText.Multiline = true;
            this.PlainText.Name = "PlainText";
            this.PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PlainText.Size = new System.Drawing.Size(525, 150);
            this.PlainText.TabIndex = 38;
            this.PlainText.TextChanged += new System.EventHandler(this.PlainText_TextChanged_1);
            // 
            // PlianLabel
            // 
            this.PlianLabel.AutoSize = true;
            this.PlianLabel.Location = new System.Drawing.Point(11, 188);
            this.PlianLabel.Name = "PlianLabel";
            this.PlianLabel.Size = new System.Drawing.Size(35, 12);
            this.PlianLabel.TabIndex = 37;
            this.PlianLabel.Text = "明文:";
            this.PlianLabel.Click += new System.EventHandler(this.PlianLabel_Click);
            // 
            // KeyText
            // 
            this.KeyText.AllowDrop = true;
            this.KeyText.Location = new System.Drawing.Point(94, 128);
            this.KeyText.Multiline = true;
            this.KeyText.Name = "KeyText";
            this.KeyText.PasswordChar = '*';
            this.KeyText.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.KeyText.Size = new System.Drawing.Size(196, 21);
            this.KeyText.TabIndex = 35;
            // 
            // KeyBtn
            // 
            this.KeyBtn.Location = new System.Drawing.Point(296, 128);
            this.KeyBtn.Name = "KeyBtn";
            this.KeyBtn.Size = new System.Drawing.Size(69, 23);
            this.KeyBtn.TabIndex = 36;
            this.KeyBtn.Text = "生成密钥";
            this.KeyBtn.UseVisualStyleBackColor = true;
            this.KeyBtn.Click += new System.EventHandler(this.KeyBtn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.KeyLabel);
            this.panel2.Controls.Add(this.DecryptionBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.PlainText);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.CipherText);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.EncryptionBtn);
            this.panel2.Controls.Add(this.CipherLabel);
            this.panel2.Controls.Add(this.PlianLabel);
            this.panel2.Controls.Add(this.KeyText);
            this.panel2.Controls.Add(this.KeyBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 626);
            this.panel2.TabIndex = 52;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 555);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 52;
            this.label4.Text = "耗时：";
            // 
            // aesjia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "aesjia";
            this.Size = new System.Drawing.Size(558, 635);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.RadioButton radioBtn3;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button DecryptionBtn;
        private System.Windows.Forms.Button EncryptionBtn;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.Label CipherLabel;
        private System.Windows.Forms.TextBox PlainText;
        private System.Windows.Forms.Label PlianLabel;
        private System.Windows.Forms.TextBox KeyText;
        private System.Windows.Forms.Button KeyBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
