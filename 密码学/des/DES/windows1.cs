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
using System.Threading;


namespace des
{

    public partial class windows1 : UserControl
    {
        Stopwatch sw1 = new Stopwatch();
        Stopwatch sw2 = new Stopwatch();
        //int c, d;
        public windows1()
        {
            
            InitializeComponent();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            const long ChunkSize = 102400;//100K 每次读取文件，只读取100K 
            using (OpenFileDialog fbd = new OpenFileDialog())
            {
               
                fbd.Filter = "(*.*)|*.txt";
                
                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    byte[] bytcontent = new byte[ChunkSize];
                    FileStream fs = new FileStream(fbd.FileName, FileMode.Open);
                    this.textBox7.Text = fbd.FileName;
                    long dataLengthToRead = fs.Length;//获取下载的文件总大小
                    
                    while (dataLengthToRead > 0)
                    {
                        int lengthRead = fs.Read(bytcontent, 0, Convert.ToInt32(ChunkSize));//读取的大小
                        Thread t = new Thread(new ParameterizedThreadStart(Readfile));
                        t.Start(System.Text.Encoding.Default.GetString(bytcontent));
                        dataLengthToRead -= lengthRead;
                    }
                    
                }
            }
        }
        public delegate void Callback(string str);
        
        private void Readfile(object content)
        {

           // sw1.Start();
            
            if (textBox1.InvokeRequired)
            {
                Callback call = new Callback(Readfile);
                this.BeginInvoke(call, new object[] { content });
            }
            else
            {
                this.textBox1.AppendText(content.ToString());
                this.textBox1.AppendText("\r\n");
            } 
          //  sw1.Stop();

           // TimeSpan ts1 = sw1.Elapsed;
            //MessageBox.Show("用时" + ts2);
           // label5.Text = ts1.ToString();
           
        }
       //快捷键
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData )
        {
            if (keyData == Keys.Enter)
            {
                this.button1.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            if (keyData == (Keys.O|Keys.Alt))
            {
                this.button3.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
           
            if (keyData == (Keys.S | Keys.Alt))
            {
                this.button4.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            return base.ProcessCmdKey(ref   msg, keyData);
        }  
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请输入要加密的字符串！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox2.Text.Length != 8)
            {
                MessageBox.Show("请输入8位密钥！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            textBox3.Text = DesEncrypt(textBox1.Text, textBox2.Text);
        }
        /// <summary>
        /// 加密原函数
        /// </summary>
        /// <param name="pToEncrypt"></param>
        /// <param name="sKey"></param>
        /// <returns></returns>
        public string DesEncrypt(string pToEncrypt, string sKey)
        {
            sw2.Start();
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
            des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();
            sw2.Stop();
            TimeSpan ts2 = sw2.Elapsed;
            //MessageBox.Show("用时" + ts2);
            label4.Text = ts2.ToString();
            return ret.ToString();
        }
        

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog file2 = new SaveFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file2.FileName);
                sw.Write(textBox3.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void windows1_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        public Keys Modifiers { get; set; }

        public string ts2 { get; set; }
    }
}
