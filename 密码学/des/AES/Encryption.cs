using System;
using System.Collections.Generic;
using System.Text;

namespace des
{
    class Encryption
    {
        public static int[,] Getencryption(string str, int[,] key)
        {
            str = str.ToLower();
            StringBuilder strB = new StringBuilder(str);
            if (strB.Length % 16 != 0)
            {
                int len = strB.Length;
                for (int i = 0; i < 32 - len % 32; i++)
                {
                    strB = strB.Append(" ");
                }
            }
            byte[] buf = Encoding.Default.GetBytes(strB.ToString());

            int[] cipherkey = new int[16];
            int[,] plain = new int[buf.Length / 16, 16];
            int[,] ciphertext = new int[buf.Length / 16, 16];
            int[] plaintext = new int[16];

            StringBuilder s = new StringBuilder(100000);
            for (int i = 0; i < buf.Length; i++)
            {
                for (int j = 7; j >= 0; j--)
                {
                    s = s.Append(buf[i] >> j & 1);
                }
            }
            for (int i = 0; i < plain.GetLength(0); i++)
            {
                for (int j = 0; j < 16; j++)
                    plain[i, j] = Convert.ToInt32(s.ToString(j * 8 + i * 128, 8), 2);
            }
            EncryptionForm encryForm = new EncryptionForm();
            encryForm.Show();
            for (int i = 0; i < plain.GetLength(0); i++)
            {
                for (int h = 0; h < 16; h++)
                {
                    cipherkey[h] = key[0, h];
                    plaintext[h] = plain[i, h];
                }
                encryForm.SetText("密钥：", cipherkey);
                plaintext = AddRoundKey(plaintext, cipherkey);
                encryForm.SetText("AddRoundKey:", plaintext);
                encryForm.Set();
                for (int j = 0; j < key.GetLength(0) - 2; j++)
                {
                    for (int h = 0; h < 16; h++)
                    {
                        cipherkey[h] = key[j + 1, h];
                    }
                    for (int h = 0; h < plaintext.Length; h++)
                    {
                        plaintext[h] = SubBytes.GetSubByte(plaintext[h]);
                    }
                    encryForm.SetText("SubBytes:", plaintext);
                    plaintext = ShiftRows(plaintext);
                    encryForm.SetText("ShiftRows:", plaintext);
                    plaintext = MixColumn.GetMixColumn(plaintext);
                    encryForm.SetText("MixColumn:", plaintext);
                    encryForm.SetText("轮密钥：", cipherkey);
                    plaintext = AddRoundKey(plaintext, cipherkey);
                    encryForm.SetText("AddRoundKey:", plaintext);
                    encryForm.Set();
                }
                for (int h = 0; h < 16; h++)
                {
                    cipherkey[h] = key[key.GetLength(0) - 1, h];
                }
                for (int h = 0; h < plaintext.Length; h++)
                {
                    plaintext[h] = SubBytes.GetSubByte(plaintext[h]);
                }
                encryForm.SetText("SubBytes:", plaintext);
                plaintext = ShiftRows(plaintext);
                encryForm.SetText("ShiftRows:", plaintext);
                encryForm.SetText("轮密钥：", cipherkey);
                plaintext = AddRoundKey(plaintext, cipherkey);
                encryForm.SetText("AddRoundKey:", plaintext);
                for (int j = 0; j < 16; j++)
                    ciphertext[i, j] = plaintext[j];
            }
            encryForm.Settext();
            return ciphertext;
        }
        public static int[] AddRoundKey(int[] cipher, int[] key)
        {
            for (int i = 0; i < 16; i++)
            {
                cipher[i] ^= key[i];
            }
            return cipher;
        }
        public static int[] ShiftRows(int[] cipher)
        {
            int[] cipherX = new int[16];

            for (int i = 0; i < 16; i++)
            {
                if (i % 4 == 0)
                    cipherX[i] = cipher[i];
                if (i % 4 == 1)
                    cipherX[i] = cipher[(i + 4) % 16];
                if (i % 4 == 2)
                    cipherX[i] = cipher[(i + 8) % 16];
                if (i % 4 == 3)
                    cipherX[i] = cipher[(i + 12) % 16];
            }
            return cipherX;
        }
    }
}
