using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace des.扩展欧几里德算法
{
    public partial class oujilide : UserControl
    {
        public oujilide()
        {
            InitializeComponent();
        }

        long x = 0, y = 0, q;
        private void swap(long a, long b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        private void ex_Eulid(long a, long b)
        {


            if (b == 0)
            {
                x = 1; y = 0; q = a;
            }
            else
            {
                ex_Eulid(b, a % b);
                long temp = x;
                x = y; y = temp - a / b * y;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("^[0-9]+$");
            Match ma = reg.Match(textBox1.Text);
            Match mb = reg.Match(textBox2.Text);
            long a=0, b=0;
            if (ma.Success && mb.Success)
            {
                //是数字 
                
                a = long.Parse(textBox1.Text);
                b = long.Parse(textBox2.Text);
                if (a < b) swap(a, b);
                ex_Eulid(a, b);
                label1.Text = q + "=" + "(" + x + ")" + "*" + a + "+" + "(" + y + ")" + "*" + b;
                label5.Text = x + "是" + a + "关于模" + b + "的乘法逆元";   
                return;
            }
            else
            {
                //不是数字
                MessageBox.Show("请正确输入数字");
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
