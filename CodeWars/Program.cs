using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.tests;

namespace CodeWars
{
    class Program
    {
        static void Main()
        {
            int[] arr = kiu6.FirstNSmallest.FirstNSmallestKata(new[] { 2, 1, 2, 3, 4, 2 }, 2);
            foreach (int i in arr)
                Console.Write(i);
            Console.ReadKey();
        }
    }
}
