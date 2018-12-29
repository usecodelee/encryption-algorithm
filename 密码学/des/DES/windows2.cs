using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Globalization;
using System.Diagnostics;

namespace des
{
    public partial class windows2 : UserControl
    {
        //Stopwatch sw3 = new Stopwatch();
        Stopwatch sw4 = new Stopwatch();
        //int a, b;
        public windows2()
        {
            InitializeComponent();
        }

        private void windows2_Load(object sender, EventArgs e)
        {
            textBox6.Focus();

        }
        //快捷键
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.button2.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            if (keyData == (Keys.O | Keys.Alt))
            {
                this.button5.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            
            if (keyData == (Keys.S | Keys.Alt))
            {
                this.button6.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            return base.ProcessCmdKey(ref   msg, keyData);
        }  
        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog File3 = new OpenFileDialog();
            File3.Filter = "文本文件|*.txt";
            if (File3.ShowDialog() == DialogResult.OK)
            {
               // sw3.Start();
                StreamReader sr = File.OpenText(File3.FileName);
                while (sr.EndOfStream != true)
                this.textBox6.Text = (sr.ReadLine());
                this.textBox8.Text = File3.FileName;
               // sw3.Stop();
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("请输入要解密的字符串！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox5.Text.Length != 8)
            {
                MessageBox.Show("请输入8位密钥！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox4.Text = DesDecrypt(textBox6.Text, textBox5.Text);
        }
        /// <summary>
        /// 解密原函数
        /// </summary>
        /// <param name="pToDecrypt"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public string DesDecrypt(string pToDecrypt, string sKey)
        {
            sw4.Start();
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
            for (int x = 0; x < pToDecrypt.Length / 2; x++)
            {
                int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            try
            {
                cs.FlushFinalBlock();
            }
            catch
            {
                return ("密钥或密文不正确！");
            }
            StringBuilder ret = new StringBuilder();
            sw4.Stop();
            TimeSpan ts3 = sw4.Elapsed;
           // a = int.Parse(sw3.ElapsedMilliseconds.ToString()); b = int.Parse(sw4.ElapsedMilliseconds.ToString());
           //MessageBox.Show("解密用时" +ts3 , "计时结果");
            label1.Text = ts3.ToString();
            return System.Text.Encoding.Default.GetString(ms.ToArray());
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            SaveFileDialog file4 = new SaveFileDialog();
            file4.Filter = "文本文件|*.txt";
            if (file4.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file4.FileName);
                sw.Write(textBox4.Text);
                sw.Flush();
                sw.Close();
            }
        }
    }
}
