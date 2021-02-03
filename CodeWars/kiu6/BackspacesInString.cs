using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class BackspacesInString
    {
        //https://www.codewars.com/kata/5727bb0fe81185ae62000ae3?utm_source=newsletter
        public static string CleanString(string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach(char c in s)
            {
                if(c.Equals('#') && sb.Length > 0)
                {
                    sb.Remove(sb.Length-1, 1);
                } else if(!c.Equals('#'))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
