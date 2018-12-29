namespace des
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gpbWindows = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.解密ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.扩展的欧几里德算法ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.millerRobinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbWindows
            // 
            this.gpbWindows.Location = new System.Drawing.Point(12, 41);
            this.gpbWindows.Name = "gpbWindows";
            this.gpbWindows.Size = new System.Drawing.Size(558, 635);
            this.gpbWindows.TabIndex = 0;
            this.gpbWindows.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dESToolStripMenuItem,
            this.aESToolStripMenuItem,
            this.presentToolStripMenuItem,
            this.扩展的欧几里德算法ToolStripMenuItem,
            this.millerRobinToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.ToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加密ToolStripMenuItem1,
            this.解密ToolStripMenuItem1});
            this.dESToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.dESToolStripMenuItem.Text = "DES";
            this.dESToolStripMenuItem.ToolTipText = "DES加密以及解密演示";
            // 
            // 加密ToolStripMenuItem1
            // 
            this.加密ToolStripMenuItem1.Name = "加密ToolStripMenuItem1";
            this.加密ToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.加密ToolStripMenuItem1.Text = "加密";
            this.加密ToolStripMenuItem1.Click += new System.EventHandler(this.加密ToolStripMenuItem1_Click);
            // 
            // 解密ToolStripMenuItem1
            // 
            this.解密ToolStripMenuItem1.Name = "解密ToolStripMenuItem1";
            this.解密ToolStripMenuItem1.Size = new System.Drawing.Size(152, 24);
            this.解密ToolStripMenuItem1.Text = "解密";
            this.解密ToolStripMenuItem1.Click += new System.EventHandler(this.解密ToolStripMenuItem1_Click);
            // 
            // aESToolStripMenuItem
            // 
            this.aESToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aESToolStripMenuItem.Name = "aESToolStripMenuItem";
            this.aESToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.aESToolStripMenuItem.Text = "AES";
            this.aESToolStripMenuItem.ToolTipText = "AES加密以及解密演示";
            this.aESToolStripMenuItem.Click += new System.EventHandler(this.aESToolStripMenuItem_Click);
            // 
            // presentToolStripMenuItem
            // 
            this.presentToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.presentToolStripMenuItem.Name = "presentToolStripMenuItem";
            this.presentToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.presentToolStripMenuItem.Text = "Present";
            this.presentToolStripMenuItem.ToolTipText = "Present加密以及解密演示";
            this.presentToolStripMenuItem.Click += new System.EventHandler(this.presentToolStripMenuItem_Click);
            // 
            // 扩展的欧几里德算法ToolStripMenuItem
            // 
            this.扩展的欧几里德算法ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.扩展的欧几里德算法ToolStripMenuItem.Name = "扩展的欧几里德算法ToolStripMenuItem";
            this.扩展的欧几里德算法ToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.扩展的欧几里德算法ToolStripMenuItem.Text = "扩展的欧几里德算法";
            this.扩展的欧几里德算法ToolStripMenuItem.Click += new System.EventHandler(this.扩展的欧几里德算法ToolStripMenuItem_Click);
            // 
            // millerRobinToolStripMenuItem
            // 
            this.millerRobinToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.millerRobinToolStripMenuItem.Name = "millerRobinToolStripMenuItem";
            this.millerRobinToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.millerRobinToolStripMenuItem.Text = "Miller-Robin";
            this.millerRobinToolStripMenuItem.Click += new System.EventHandler(this.millerRobinToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.ToolTipText = "作者信息";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.AutoToolTip = true;
            this.ToolStripMenuItem1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.ToolStripMenuItem1.Text = "清空";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpbWindows);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "密码学与安全计算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbWindows;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 解密ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 扩展的欧几里德算法ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem millerRobinToolStripMenuItem;
    }
}