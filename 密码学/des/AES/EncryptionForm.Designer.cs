namespace des
{
    partial class EncryptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.EncrypText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "加密解过程";
            // 
            // EncrypText
            // 
            this.EncrypText.AcceptsReturn = true;
            this.EncrypText.Location = new System.Drawing.Point(19, 57);
            this.EncrypText.Multiline = true;
            this.EncrypText.Name = "EncrypText";
            this.EncrypText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.EncrypText.Size = new System.Drawing.Size(353, 447);
            this.EncrypText.TabIndex = 2;
            this.EncrypText.TextChanged += new System.EventHandler(this.EncrypText_TextChanged);
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EncrypText);
            this.Name = "EncryptionForm";
            this.Text = "EncryptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EncrypText;

    }
}