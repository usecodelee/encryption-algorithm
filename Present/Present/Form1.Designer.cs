namespace Present
{
    partial class Form1
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
            this.tbxP = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaintext";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbxP
            // 
            this.tbxP.Location = new System.Drawing.Point(25, 33);
            this.tbxP.Multiline = true;
            this.tbxP.Name = "tbxP";
            this.tbxP.Size = new System.Drawing.Size(381, 85);
            this.tbxP.TabIndex = 1;
            this.tbxP.TextChanged += new System.EventHandler(this.tbxP_TextChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(25, 341);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(120, 31);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Submit";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(25, 141);
            this.tbxKey.Multiline = true;
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(381, 85);
            this.tbxKey.TabIndex = 4;
            this.tbxKey.TextChanged += new System.EventHandler(this.tbxKey_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbxRes
            // 
            this.tbxRes.Location = new System.Drawing.Point(25, 250);
            this.tbxRes.Multiline = true;
            this.tbxRes.Name = "tbxRes";
            this.tbxRes.Size = new System.Drawing.Size(381, 85);
            this.tbxRes.TabIndex = 6;
            this.tbxRes.TextChanged += new System.EventHandler(this.tbxRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 384);
            this.Controls.Add(this.tbxRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxP);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRes;
        private System.Windows.Forms.Label label3;
    }
}

