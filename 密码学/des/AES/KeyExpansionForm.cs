using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace des
{
    public partial class KeyExpansionForm : Form
    {
        private static char[] alphabet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
        StringBuilder str = new StringBuilder();
        public KeyExpansionForm()
        {
            InitializeComponent();
            str = new StringBuilder();
        }
        public void SetText(int[,] keyExpansion)
        {
            StringBuilder s = new StringBuilder(8);
            byte[] buf = new byte[2];

            for (int i = 0; i < keyExpansion.GetLength(0); i++)
            {
                for (int j = 0; j < keyExpansion.GetLength(1); j++)
                {
                    s = SubBytes.GetStr(keyExpansion[i, j]);
                    buf[0] = Convert.ToByte(s.ToString(0, 4), 2);
                    buf[1] = Convert.ToByte(s.ToString(4, 4), 2);
                    str.Append(alphabet[buf[0]] + "" + alphabet[buf[1]]);
                }
                str.Append("\n");
            }
        }
        public void Settext()
        {
            KeyExpansionText.Text = str.ToString();
        }

        private void KeyExpansionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}