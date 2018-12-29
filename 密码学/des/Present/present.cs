using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace des
{
    public partial class present : UserControl
    {
        public present()
        {
            InitializeComponent();
        }
        private void present_Load(object sender, EventArgs e)
        {
            tbxP.Focus();

        }

        
        
//S盒
void Sub_bytes(ref byte[] s)
{
    byte[] sbox = new byte[]{
        0x0c, 0x05, 0x06, 0x0b,
        0x09, 0x00, 0x0a, 0x0d,
        0x03, 0x0e, 0x0f, 0x08,
        0x04, 0x07, 0x01, 0x02
    };
    for (int i = 0; i < 16; i++)
    {
        s[i] = sbox[s[i]];
    }
}
//P变换
void Exchange(ref byte[] s)
{
    byte[] rPx =new byte[]{
        0,4,8,12,16,20,24,28,32,36,40,44,48,52,56,60,
        1,5,9,13,17,21,25,29,33,37,41,45,49,53,57,61,
        2,6,10,14,18,22,26,30,34,38,42,46,50,54,58,62,
        3,7,11,15,19,23,27,31,35,39,43,47,51,55,59,63
    };
    byte row1, col1, row, col, shift, shift1, tmp;
    byte[] buf = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    for (int i = 0; i < 64; i++)
    {
        shift1 = 0x08;
        row1 = Convert.ToByte(i / 4);
        col1 = Convert.ToByte(i % 4);
        shift1 >>= col1;
        shift = 0x08;
        tmp = rPx[i];
        row = Convert.ToByte(tmp / 4);
        col = Convert.ToByte(tmp % 4);
        shift >>= col;
        if ((shift & s[row]) != 0)
        {

            buf[row1] |= shift1;
        }
    }
            s = new byte[buf.Length];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = buf[i];
            }
}
//加密函数
void UpdataKeys(ref byte[] k, int r)
{
    byte[] sbox = new byte[]{
        0x0c, 0x05, 0x06, 0x0b,
        0x09, 0x00, 0x0a, 0x0d,
        0x03, 0x0e, 0x0f, 0x08,
        0x04, 0x07, 0x01, 0x02
    };
    byte[] tmpk1 = new byte[20];
    int i;
            for (i = 0; i < 20; i++)
            {
                tmpk1[i] = k[i];
            }

    k[0] = Convert.ToByte(((tmpk1[15] << 1) | (tmpk1[16] >> 3)) & 0x0f);
    k[1] = Convert.ToByte(((tmpk1[16] << 1) | (tmpk1[17] >> 3)) & 0x0f);
    k[2] = Convert.ToByte(((tmpk1[17] << 1) | (tmpk1[18] >> 3)) & 0x0f);
    k[3] = Convert.ToByte(((tmpk1[18] << 1) | (tmpk1[19] >> 3)) & 0x0f);
    k[4] = Convert.ToByte(((tmpk1[19] << 1) | (tmpk1[0] >> 3)) & 0x0f);
    k[5] = Convert.ToByte(((tmpk1[0] << 1) | (tmpk1[1] >> 3)) & 0x0f);
    k[6] = Convert.ToByte(((tmpk1[1] << 1) | (tmpk1[2] >> 3)) & 0x0f);
    k[7] = Convert.ToByte(((tmpk1[2] << 1) | (tmpk1[3] >> 3)) & 0x0f);
    k[8] = Convert.ToByte(((tmpk1[3] << 1) | (tmpk1[4] >> 3)) & 0x0f);
    k[9] = Convert.ToByte(((tmpk1[4] << 1) | (tmpk1[5] >> 3)) & 0x0f);
    k[10] = Convert.ToByte(((tmpk1[5] << 1) | (tmpk1[6] >> 3)) & 0x0f);
    k[11] = Convert.ToByte(((tmpk1[6] << 1) | (tmpk1[7] >> 3)) & 0x0f);
    k[12] = Convert.ToByte(((tmpk1[7] << 1) | (tmpk1[8] >> 3)) & 0x0f);
    k[13] = Convert.ToByte(((tmpk1[8] << 1) | (tmpk1[9] >> 3)) & 0x0f);
    k[14] = Convert.ToByte(((tmpk1[9] << 1) | (tmpk1[10] >> 3)) & 0x0f);
    k[15] = Convert.ToByte(((tmpk1[10] << 1) | (tmpk1[11] >> 3)) & 0x0f);
    k[16] = Convert.ToByte(((tmpk1[11] << 1) | (tmpk1[12] >> 3)) & 0x0f);
    k[17] = Convert.ToByte(((tmpk1[12] << 1) | (tmpk1[13] >> 3)) & 0x0f);
    k[18] = Convert.ToByte(((tmpk1[13] << 1) | (tmpk1[14] >> 3)) & 0x0f);
    k[19] = Convert.ToByte(((tmpk1[14] << 1) | (tmpk1[15] >> 3)) & 0x0f);

    k[0] = sbox[k[0]];

    r = r << 3;

    k[15] = Convert.ToByte((k[15] ^ (r >> 4)) & 0x0f);
    k[16] = Convert.ToByte((k[16] ^ (r % 16)) & 0x0f);

}

void AddRoundKeys(ref byte[] p, ref byte[] k)
{
            for (int i = 0; i < 16; i++)
            {
                p[i] ^= k[i];
            }
}
void Encrypt(ref byte[] p, ref byte[] k)//p:明文   k:密钥
{
    int i;
    for (i = 0; i < 31; i++)
    {
        AddRoundKeys(ref p, ref k);
        Sub_bytes(ref p);
        Exchange(ref p);
        UpdataKeys(ref k, i + 1);   //扩展密钥
                                //	printblock(p); puts("");
                                //	printblock(k,20);
                                //	puts("");
    }
    AddRoundKeys(ref p, ref k);
}
        private static byte[] strToHexByte(string hexString)
        {
            hexString = hexString.Replace(" ", "").Replace("0x", "");
            byte[] returnBytes = new byte[hexString.Length];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i, 1), 16);
            return returnBytes;
        }
        Stopwatch sw1 = new Stopwatch();
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbxP.Text.Length == 0 || Encoding.Default.GetBytes(tbxP.Text).Length != 16)
            {
                MessageBox.Show("请输入16位明文！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tbxKey.Text.Length == 0 || Encoding.Default.GetBytes(tbxP.Text).Length != 16)
            {
                MessageBox.Show("请输入20位密钥！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            sw1.Start();
            byte[] p = strToHexByte(tbxP.Text.Trim());
            //byte[] p = new byte[] {0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f, 0x0f,
            //    0x0f,0x0f,0x0f,0x0f,0x0f,0x0f,0x0f,0x0f };
            byte[] k = strToHexByte(tbxKey.Text.Trim());

            Encrypt(ref p, ref k);
            tbxRes.Text = "";
            for (int i = 0; i < p.Length; i++)
            {
                tbxRes.AppendText(p[i].ToString("X"));
            }
            sw1.Stop();
            TimeSpan ts1 = sw1.Elapsed;
            label5.Text = ts1.ToString();
            //MessageBox.Show("加密用时" + ts1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbxP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbxRes_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog file2 = new SaveFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file2.FileName);
                sw.Write(tbxRes.Text);
                sw.Flush();
                sw.Close();
            }
        }
        //快捷键
        protected override bool ProcessCmdKey(ref   Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                this.btnOK.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            if (keyData == (Keys.O | Keys.Alt))
            {
                this.button3.PerformClick();
                //this.btnTempTest.PerformClick();  
            }
            
        
            return base.ProcessCmdKey(ref   msg, keyData);
        }  
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog File1 = new OpenFileDialog();
            File1.Filter = "文本文件|*.txt";

            if (File1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(File1.FileName, Encoding.Default);
                while (sr.EndOfStream != true)
                    this.tbxP.Text += (sr.ReadLine());
                this.textBox1.Text = File1.FileName;
                //MessageBox.Show(sw1.ElapsedMilliseconds.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog file2 = new SaveFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file2.FileName);
                sw.Write(tbxP.Text);
                sw.Flush();
                sw.Close();
            }
        }
    }
}

       
    

