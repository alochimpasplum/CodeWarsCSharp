using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class SumParts
    {
        // https://www.codewars.com/kata/5ce399e0047a45001c853c2b/train/csharp
        public static int[] PartsSums(int[] ls)
        {
            int[] result = new int[ls.Length + 1];

            for (int i = ls.Length - 1; i >= 0; i--)
                result[i] = ls[i] + result[i+1];

            return result;
        }
    }
}
