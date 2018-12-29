using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace des
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            this.skinEngine1.SkinFile = "PageColor2.ssk";
            w1 = new windows1();
            w2 = new windows2();
            w3 = new aesjia();
            w4 = new present();
            w5 = new des.扩展欧几里德算法.oujilide();
            w6 = new 素性检测.Miller_Robin();
            w1.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w1);
        }

        public windows1 w1;
        public windows2 w2;
        public aesjia w3;
        public present w4;
        public des.扩展欧几里德算法.oujilide w5;
        public des.素性检测.Miller_Robin w6;
        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("密码学与安全计算实验\n\n作者：\n         李朝江", "关于", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        //快捷键
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            
            if (keyData == (Keys.C | Keys.Alt))
            {
                this.ToolStripMenuItem1.PerformClick();
                //this.btnTempTest.PerformClick();  
            }


            return base.ProcessCmdKey(ref   msg, keyData);
        }  
        private void 加密ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            w1.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w1);
        }

        private void 解密ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            w2.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w2);
        }

        private void aESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w3.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w3);
        }

        private void presentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w4.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w4);
        }
        //清空文本框函数
        private void ClearText(Control ctrlTop)
        {
            if (ctrlTop.GetType() == typeof(TextBox))
                ctrlTop.Text = "";
            else
            {
                foreach (Control ctrl in ctrlTop.Controls)
                {
                    ClearText(ctrl); //循环调用  
                }
            }
        }
        /*//清空label函数
        private void Clearlab(Control ctrlTop)
        {
            if (ctrlTop.GetType() == typeof(Label))
                ctrlTop.Text = "";
            else
            {
                foreach (Control ctrl in ctrlTop.Controls)
                {
                    Clearlab(ctrl); //循环调用  
                }
            }
        }*/

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearText(this);
            //Clearlab(this);
        }

        private void 扩展的欧几里德算法ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w5.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w5);
        }

        private void millerRobinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w6.Show();
            gpbWindows.Controls.Clear();
            gpbWindows.Controls.Add(w6);
        }
    }
}
