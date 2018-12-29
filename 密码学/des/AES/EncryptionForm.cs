using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace des
{
    public partial class EncryptionForm : Form
    {
        private static char[] alphabet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        StringBuilder strB = new StringBuilder();

        public EncryptionForm()
        {
            InitializeComponent();
        }
        public void SetText(string str, int[] cipher)
        {
            StringBuilder s = new StringBuilder();
            byte[] buf = new byte[2];

            strB.Append("\n");
            strB.Append(str);
            for (int i = 0; i < cipher.Length; i++)
            {
                s = SubBytes.GetStr(cipher[i]);
                buf[0] = Convert.ToByte(s.ToString(0, 4), 2);
                buf[1] = Convert.ToByte(s.ToString(4, 4), 2);
                strB.Append(alphabet[buf[0]] + "" + alphabet[buf[1]]);
            }
            strB.Append("\r\n");
        }
        public void Set()
        {
            strB.Append("\r");
        }
        public void Settext()
        {
            EncrypText.Text = strB.ToString();
        }

        private void EncrypText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}