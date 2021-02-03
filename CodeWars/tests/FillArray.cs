using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.tests
{
    public static class FillArray
    {
        public static int[] FillThisArray(int elements)
        {
            int[] arr = new int[elements];
            Random rnd = new Random();

            for (int i = 0; i < elements; i++)
            {
                arr[i] = rnd.Next(0, 500);
            }

            return arr;
        }
    }
}
