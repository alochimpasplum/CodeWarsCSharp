using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class ErrorCorrection1HammingCode
    {
        // https://www.codewars.com/kata/5ef9ca8b76be6d001d5e1c3e/train/csharp
        public static string Encode(string text)
        {
            byte[] ascii = Encoding.ASCII.GetBytes(text);
            StringBuilder sb = new StringBuilder();

            foreach(byte asci in ascii)
            {
                string temp = Convert.ToString(asci, 2).PadLeft(8,'0');

                foreach (char c in temp)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        sb.Append(c);
                    }
                }
            }
            return sb.ToString();
        }
        public static string Decode(string bits)
        {
            StringBuilder sb = new StringBuilder();
            string[] triplets = new string[bits.Length/3];
            byte[] ascii = new byte[(bits.Length / 3) / 8];

            for (int i = 0; i < triplets.Length; i++)
            {
                triplets[i] = bits.Substring(i * 3, 3);

                if (!triplets[i].Equals("000") || !triplets[i].Equals("111"))
                    triplets[i] = Fix(triplets[i]);

                sb.Append(triplets[i][0]);

                if (sb.Length == 8)
                {
                    ascii[i / 8] = Convert.ToByte(sb.ToString(), 2);
                    Console.WriteLine(ascii[i / 8]);
                    sb.Clear();
                }
            }

            return Encoding.ASCII.GetString(ascii);
        }
        private static string Fix(string stringToFix)
        {
            int zeros = 0;
            for (int i = 0; i < 3; i++)
            {
                if (stringToFix[i] == '0')
                    zeros++;
            }
            return (zeros > 1 ) ? "000" : "111";
        }
    }
}
