using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace des
{
    public partial class aesjia : UserControl
    {
        public aesjia()
        {
            InitializeComponent();
        }
        private static char[] alphabet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        private void aesjia_Load(object sender, EventArgs e)
        {
            PlainText.Focus();
        }
        private void CipherLabel_Click(object sender, EventArgs e)
        {

        }
        private void PlainText_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void radioBtn4_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioBtn3_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.CheckFileExists = true;
            openfile.CheckPathExists = true;
            openfile.Filter = "文本文件(*.txt)|*.txt";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openfile.FileName, System.Text.Encoding.Default);
                CipherText.Text = stream.ReadToEnd();
                stream.Close();
                this.textBox1.Text = openfile.FileName;
            }
        }
        private void PlainText_TextChanged_1(object sender, EventArgs e)
        {

        }
        

        private void PlianLabel_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.CheckFileExists = true;
            openfile.CheckPathExists = true;
            openfile.Filter = "文本文件(*.txt)|*.txt";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                StreamReader stream = new StreamReader(openfile.FileName, System.Text.Encoding.Default);
                PlainText.Text = stream.ReadToEnd();
                stream.Close();
                this.textBox1.Text = openfile.FileName;
            }
        }
        Stopwatch sw4 = new Stopwatch();
        Stopwatch sw5 = new Stopwatch();
        private void EncryptionBtn_Click_1(object sender, EventArgs e)
        {
           
            if (radioBtn1.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 16)
                {
                    MessageBox.Show("ERROR!密钥个数必须为16个字符或8个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn2.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 24)
                {
                    MessageBox.Show("ERROR!密钥个数必须为24个字符或12个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn3.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 32)
                {
                    MessageBox.Show("ERROR!密钥个数必须为32个字符或16个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
               
                if (KeyText.Text.Length == 0)
                {
                    MessageBox.Show("请输入密钥！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (PlainText.Text.Length == 0 && KeyText.Text.Length != 0)
                {
                    MessageBox.Show("请输入明文！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sw4.Start();
                int[,] key = KeyExpansion.GetKeyExpansion(KeyText.Text.ToString().Trim());
                int[,] cipher = Encryption.Getencryption(PlainText.Text.ToString(), key);

                StringBuilder strB = new StringBuilder();
                for (int i = 0; i < cipher.GetLength(0); i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        StringBuilder s = new StringBuilder();
                        byte[] buf = new byte[2];
                        s = SubBytes.GetStr(cipher[i, j]);
                        buf[0] = Convert.ToByte(s.ToString(0, 4), 2);
                        buf[1] = Convert.ToByte(s.ToString(4, 4), 2);
                        strB.Append(alphabet[buf[0]] + "" + alphabet[buf[1]]);
                    }
                }
                CipherText.Text = strB.ToString();
                sw4.Stop();
            }
            
            TimeSpan ts3 = sw4.Elapsed;
            label2.Text = ts3.ToString();
            //MessageBox.Show("解密用时" + ts3, "计时结果");
        }
        private void DecryptionBtn_Click_1(object sender, EventArgs e)
        {
            if (radioBtn1.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 16)
                {
                    MessageBox.Show("密钥个数必须为16个字符或8个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn2.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 24)
                {
                    MessageBox.Show("密钥个数必须为24个字符或12个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn3.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 32)
                {
                    MessageBox.Show("密钥个数必须为32个字符或16个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (KeyText.Text.Length == 0)
                {
                    MessageBox.Show("请输入密钥！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (CipherText.Text.Length == 0 && KeyText.Text.Length != 0)
                {
                    MessageBox.Show("请输入密文！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                sw4.Start();
                int[,] key = KeyExpansion.GetKeyExpansion(KeyText.Text.ToString().Trim());
                int[,] cipherKey = new int[key.GetLength(0), key.GetLength(1)];
                int[] key1 = new int[key.GetLength(1)];
                for (int i = 0; i < key.GetLength(1); i++)
                {
                    cipherKey[0, i] = key[0, i];
                    cipherKey[key.GetLength(0) - 1, i] = key[key.GetLength(0) - 1, i];
                }
                for (int i = 1; i < key.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < key.GetLength(1); j++)
                    {
                        key1[j] = key[i, j];
                    }
                    key1 = MixColumn.InvMixColumn(key1);
                    for (int j = 0; j < key.GetLength(1); j++)
                    {
                        cipherKey[i, j] = key1[j];
                    }
                }
                int[,] plain = Decryption.Getdecryption(CipherText.Text.ToString(), cipherKey);
                StringBuilder strB = new StringBuilder();
                StringBuilder s = new StringBuilder();
                byte[] result = new byte[plain.GetLength(0) * 16];

                for (int i = 0; i < plain.GetLength(0); i++)
                {
                    for (int j = 0; j < 16; j++)
                    {
                        for (int h = 7; h >= 0; h--)
                        {
                            s.Append(plain[i, j] >> h & 1);
                        }
                    }
                }
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = Convert.ToByte(s.ToString(i * 8, 8), 2);
                }
                strB.Append(Encoding.Default.GetString(result));
                PlainText.Text = strB.ToString();
                sw4.Stop();
            }
            TimeSpan ts4 = sw4.Elapsed;
            label2.Text = ts4.ToString();
            //MessageBox.Show("解密用时" + ts4, "计时结果");
        }
        private void KeyBtn_Click_1(object sender, EventArgs e)
        {
            if (radioBtn1.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 16)
                {
                    MessageBox.Show("ERROR!密钥个数必须为16个字符或8个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn2.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 24)
                {
                    MessageBox.Show("ERROR!密钥个数必须为24个字符或12个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (radioBtn3.Checked == true)
            {
                if (Encoding.Default.GetBytes(KeyText.Text).Length != 32)
                {
                    MessageBox.Show("ERROR!密钥个数必须为32个字符或16个汉字！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (true)
                {
                    int[,] key = KeyExpansion.GetKeyExpansion(KeyText.Text.ToString().Trim());
                    KeyExpansionForm KeyForm = new KeyExpansionForm();
                    KeyForm.Show();
                    KeyForm.SetText(key);
                    KeyForm.Settext();
                }
                if (true)
                {
                    int[,] key = KeyExpansion.GetKeyExpansion(KeyText.Text.ToString().Trim());
                    int[,] cipherKey = new int[key.GetLength(0), key.GetLength(1)];
                    int[] key1 = new int[key.GetLength(1)];
                    for (int i = 0; i < key.GetLength(1); i++)
                    {
                        cipherKey[0, i] = key[0, i];
                        cipherKey[key.GetLength(0) - 1, i] = key[key.GetLength(0) - 1, i];
                    }
                    for (int i = 1; i < key.GetLength(0) - 1; i++)
                    {
                        for (int j = 0; j < key.GetLength(1); j++)
                        {
                            key1[j] = key[i, j];
                        }
                        key1 = MixColumn.InvMixColumn(key1);
                        for (int j = 0; j < key.GetLength(1); j++)
                        {
                            cipherKey[i, j] = key1[j];
                        }
                    }
                    KeyExpansionForm KeyForm = new KeyExpansionForm();
                    KeyForm.Show();
                    KeyForm.SetText(cipherKey);
                    KeyForm.Settext();
                }
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog file2 = new SaveFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file2.FileName);
                sw.Write(PlainText.Text);
                sw.Flush();
                sw.Close();
            }
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog file2 = new SaveFileDialog();
            file2.Filter = "文本文件|*.txt";
            if (file2.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(file2.FileName);
                sw.Write(CipherText.Text);
                sw.Flush();
                sw.Close();
            }
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }  
    }
}