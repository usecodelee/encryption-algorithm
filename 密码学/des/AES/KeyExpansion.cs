using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace des
{
    class KeyExpansion
    {
        public static int[,] Rcon =
        {
            {0x00,0x00,0x00,0x00},
		    {0x01,0x00,0x00,0x00},
		    {0x02,0x00,0x00,0x00},
		    {0x04,0x00,0x00,0x00},
		    {0x08,0x00,0x00,0x00},
		    {0x10,0x00,0x00,0x00},
		    {0x20,0x00,0x00,0x00},
		    {0x40,0x00,0x00,0x00},
            {0x80,0x00,0x00,0x00},
            {0x1b,0x00,0x00,0x00},
            {0x36,0x00,0x00,0x00}
        };

        public static int[,] GetKeyExpansion(string str)
        {
            str = str.ToLower();
            byte[] buf = Encoding.Default.GetBytes(str);
            StringBuilder s = new StringBuilder(128);

            int nb = 4;
            int nk = buf.Length / 4;
            int nr = 0;
            switch (nk)
            {
                case 4: nr = 10;
                    break;
                case 6: nr = 12;
                    break;
                case 8: nr = 14;
                    break;
            }
            int[,] key = new int[nb * (nr + 1), nb];
            int[,] cipherKey = new int[nr + 1, 16];
            int[] temp = new int[4];

            for (int i = 0; i < buf.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    s = s.Append(buf[i] >> j & 1);
                }
            }
            for (int i = 0; i < nk; i++)
            {
                for (int j = 0; j < nb; j++)
                {
                    key[i, j] = Convert.ToInt32(s.ToString(8 * j + i * 32, 8), 2);
                }
            }
            for (int i = nk; i < nb * (nr + 1); i++)
            {
                temp[0] = key[i - 1, 0];
                temp[1] = key[i - 1, 1];
                temp[2] = key[i - 1, 2];
                temp[3] = key[i - 1, 3];
                for (int j = 0; j < nb; j++)
                {
                    if (i % nk == 0)
                    {
                        temp[j] = SubBytes.GetSubByte(key[i - 1, (j + 1) % 4]) ^ Rcon[i / nk, j];
                    }
                    else if ((nk > 6) && (i % nk == 4))
                    {
                        temp[j] = SubBytes.GetSubByte(key[i - 1, j]);
                    }
                    key[i, j] = temp[j] ^ key[i - nk, j];
                }
            }
            for (int i = 0; i < nr + 1; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    cipherKey[i, j] = key[j / 4 + i * 4, j % 4];
                }
            }
            return cipherKey;
        }
    }
}
