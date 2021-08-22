using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.tests;
using System.Diagnostics;

namespace CodeWars
{
    class Program
    {
        static void Main()
        {
            int[] result = kiu6.BuyingACar.nbMonths(2000, 8000, 1000, 1.5);
            Console.WriteLine($"Resultado: [{result[0]},{result[1]}]");
            result = kiu6.BuyingACar.nbMonths(12000, 8000, 1000, 1.5);
            Console.WriteLine($"Resultado: [{result[0]},{result[1]}]");
        }
    }
}
