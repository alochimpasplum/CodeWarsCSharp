using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class MultiplesOf3Or5
    {
        // https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
        public static int Solution(int value)
        {
            int sum = 0;
            for (int i = value - 1; i > 0; i--)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum;
        }
    }
}
