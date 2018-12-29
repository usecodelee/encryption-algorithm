using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;  

namespace des.素性检测
{
    public partial class Miller_Robin : UserControl
    {
        public Miller_Robin()
        {
            InitializeComponent();
        }
        Stopwatch sw1 = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        UInt64 ModMul(UInt64 a, UInt64 b, UInt64 n)//快速积取模 a*b%n  
        {
            UInt64 ans = 0;
            while (b != 0)
            {
                if ((b & 1) != 0)
                    ans = (ans + a) % n;
                a = (a + a) % n;
                b >>= 1;
            }
            return ans;
        }
        UInt64 ModExp(UInt64 a, UInt64 b, UInt64 n)//快速幂取模 a^b%n  
        {
            UInt64 ans = 1;
            while (b != 0)
            {
                if ((b & 1) != 0)
                    ans = ModMul(ans, a, n);
                a = ModMul(a, a, n);
                b >>= 1;
            }
            return ans;
        }
        bool miller_rabin(UInt64 n)//Miller-Rabin素数检测算法  
        {
            Random rd = new Random();
            UInt64 i, j, a, x, y, t, u, s = 10;
            if (n == 2)
                return true;
            if (n < 2 || (n & 1) == 0)
                return false;
            for (t = 0, u = n - 1; (u & 1) == 0; t++, u >>= 1) ;//n-1=u*2^t  
            for (i = 0; i < s; i++)
            {
                a = Convert.ToUInt64(rd.Next()) % (n - 1) + 1;
                x = ModExp(a, u, n);
                for (j = 0; j < t; j++)
                {
                    y = ModMul(x, x, n);
                    if (y == 1 && x != 1 && x != n - 1)
                        return false;
                    x = y;
                }
                if (x != 1)
                    return false;
            }
            return true;
        }
        //快捷键
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.button1.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
           
            return base.ProcessCmdKey(ref   msg, keyData);
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            sw2.Start();
            //UInt64 tmp;
            //if (!UInt64.TryParse(textBox1.Text, out tmp))
           // {
                //MessageBox.Show("请正确输入数字");
           // }
          //  else
           // {
            
     Regex   reg=new   Regex("^[0-9]+$");  
     Match   ma=reg.Match(textBox1.Text);  
     if(ma.Success)  
     {  
      //是数字 
         UInt64 num = Convert.ToUInt64(textBox1.Text.Trim());
         if (miller_rabin(num))
         {
             label13.Text = "该数是素数";
         }
         else
         {
             label13.Text = "该数不是素数";
             // }
         }
     }  
     else  
     {  
     //不是数字
         MessageBox.Show("请正确输入数字");
     }
     sw2.Stop();
     TimeSpan ts2 = sw2.Elapsed;
     //MessageBox.Show("用时" + ts2);
     label6.Text = ts2.ToString();
               
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw1.Start();

            UInt64 Num = Convert.ToUInt64(textBox2.Text.Trim());
            string s;
            UInt64 i;
            for (i = Num - 1; i > 1; i--)
            {
                if (Num % i == 0)
                {
                    break;
                }
            }
            if (i == 1)
            {
                s = "整数 " + Num.ToString() + " 是素数！";
                label5.Text = s;
            }
            else
            {
                s = "整数 " + Num.ToString() + " 不是素数！";
                label5.Text = s;

            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            //MessageBox.Show("用时" + ts1);
            label7.Text = ts1.ToString();
        }
    }
}
