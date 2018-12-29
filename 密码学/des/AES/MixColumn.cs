using System;
using System.Collections.Generic;
using System.Text;

namespace des
{
    class MixColumn
    {
        private static int[] inLogTable =
		 {     //生成元为03的反对数表
		       1,3,5,15,17,51,85,255,26,46,114,150,161,248,19,53,
		       95,225,56,72,216,115,149,164,247,2,6,10,30,34,102,170,
			   229,52,92,228,55,89,235,38,106,190,217,112,144,171,230,49,
			   83,245,4,12,20,60,68,204,79,209,104,184,211,110,178,205,
			   76,212,103,169,224,59,77,215,98,166,241,8,24,40,120,136,
			   131,158,185,208,107,189,220,127,129,152,179,206,73,219,118,154,
			   181,196,87,249,16,48,80,240,11,29,39,105,187,214,97,163,
			   254,25,43,125,135,146,173,236,47,113,147,174,233,32,96,160,
               251,22,58,78,210,109,183,194,93,231,50,86,250,21,63,65,
			   195,94,226,61,71,201,64,192,91,237,44,116,156,191,218,117,
			   159,186,213,100,172,239,42,126,130,157,188,223,122,142,137,128,
			   155,182,193,88,232,35,101,175,234,37,111,177,200,67,197,84 ,
               252,31,33,99,165,244,7,9,27,45,119,153,176,203,70,202,
               69,207,74,222,121,139,134,145,168,227,62,66,198,81,243,14,
               18,54,90,238,41,123,141,140,143,138,133,148,167,242,13,23,
               57,75,221,124,132,151,162,253,28,36,108,180,199,82,246,1
           };

        public static int[] GetMixColumn(int[] cipher)
        {
            int[] mixcolumn = new int[16];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    mixcolumn[j + i * 4] = SetMixcolumn(cipher[0 + i * 4], cipher[1 + i * 4], cipher[2 + i * 4], cipher[3 + i * 4], j + i * 4);
                }
            }
            return mixcolumn;
        }
        private static int SetMixcolumn(int a, int b, int c, int d, int n)
        {
            int mixColumn = 0;

            switch (n % 4)
            {
                case 0:
                    {
                        mixColumn = mul2(a);
                        mixColumn ^= (b == 0) ? 0 : inLogTable[(getNum(b) + 1) % 256];
                        mixColumn = (mixColumn ^ c ^ d) % 256;
                        break;
                    }
                case 1:
                    {
                        mixColumn = mul2(b);
                        mixColumn ^= (c == 0) ? 0 : inLogTable[(getNum(c) + 1) % 256];
                        mixColumn = (mixColumn ^ a ^ d) % 256;
                        break;
                    }
                case 2:
                    {
                        mixColumn = mul2(c);
                        mixColumn ^= (d == 0) ? 0 : inLogTable[(getNum(d) + 1) % 256];
                        mixColumn = (mixColumn ^ a ^ b) % 256;
                        break;
                    }
                case 3:
                    {
                        mixColumn = mul2(d);
                        mixColumn ^= (a == 0) ? 0 : inLogTable[(getNum(a) + 1) % 256];
                        mixColumn = (mixColumn ^ b ^ c) % 256;
                        break;
                    }
            }
            return mixColumn;
        }
        public static int[] InvMixColumn(int[] cipher)
        {
            int[] invMixcolumn = new int[16];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    invMixcolumn[j + i * 4] = GetInvMixcolumn(cipher[0 + i * 4], cipher[1 + i * 4], cipher[2 + i * 4], cipher[3 + i * 4], j + i * 4);
                }
            }
            return invMixcolumn;
        }
        private static int GetInvMixcolumn(int a, int b, int c, int d, int n)
        {
            int invmixColumn = 0;

            switch (n % 4)
            {
                case 0:
                    {
                        invmixColumn = (mule(a) ^ mulb(b) ^ muld(c) ^ mul9(d)) % 256;
                        break;
                    }
                case 1:
                    {
                        invmixColumn = (mul9(a) ^ mule(b) ^ mulb(c) ^ muld(d)) % 256;
                        break;
                    }
                case 2:
                    {
                        invmixColumn = (muld(a) ^ mul9(b) ^ mule(c) ^ mulb(d)) % 256;
                        break;
                    }
                case 3:
                    {
                        invmixColumn = (mulb(a) ^ muld(b) ^ mul9(c) ^ mule(d)) % 256;
                        break;
                    }
            }
            return invmixColumn;
        }
        private static int getNum(int num)
        {
            int i = 0;
            for (; i < 256; i++)
            {
                if (num == inLogTable[i])
                    break;
            }
            return i;
        }
        private static int mul2(int x)
        {
            int mix = 0;
            if ((x >> 7 & 1) == 1)
                mix ^= (x << 1) ^ 0x1b;
            else
                mix ^= x << 1;
            return mix;
        }
        private static int mul9(int x)
        {
            int mix = x;
            for (int i = 0; i < 3; i++)
            {
                mix = mul2(mix) % 256;
            }
            mix ^= x;
            return mix;
        }
        private static int mulb(int x)
        {
            int mix = 0;
            mix = mul2(x) ^ mul9(x);
            return mix;
        }
        private static int muld(int x)
        {
            int mix = x;
            for (int i = 0; i < 2; i++)
            {
                mix = mul2(mix);
            }
            mix ^= mul9(x);
            return mix;
        }
        private static int mule(int x)
        {
            int mix = x;
            int a = x;
            for (int i = 0; i < 3; i++)
            {
                mix = mul2(mix);
            }
            for (int i = 0; i < 2; i++)
            {
                a = mul2(a);
            }
            mix ^= a ^ mul2(x) % 256;
            return mix;
        }
    }
}
