namespace des
{
    partial class KeyExpansionForm
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
            this.KeyExpansionText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "扩展密钥为：";
            // 
            // KeyExpansionText
            // 
            this.KeyExpansionText.Location = new System.Drawing.Point(35, 31);
            this.KeyExpansionText.Multiline = true;
            this.KeyExpansionText.Name = "KeyExpansionText";
            this.KeyExpansionText.Size = new System.Drawing.Size(260, 281);
            this.KeyExpansionText.TabIndex = 2;
            // 
            // KeyExpansionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyExpansionText);
            this.Name = "KeyExpansionForm";
            this.Text = "KeyExpansionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyExpansionText;
    }
}