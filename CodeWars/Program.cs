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
            int testNumbers = 5;
            List<long> executionTimes = new List<long>();
            Stopwatch watch = new Stopwatch();
            Dictionary<int, long> times = new Dictionary<int, long>();

            //int[] arr = kiu6.SumParts.PartsSums(new int[] { 0, 1, 3, 6, 10 });

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + ",");
            //}
            //Console.WriteLine();

            for (int i = 1; i <= testNumbers; i++)
            {
                int[] arr = FillArray.FillThisArray(i);

                watch.Start();
                kiu6.SumParts.PartsSums(arr);
                watch.Stop();
                times.Add(i, watch.ElapsedMilliseconds);
            }

            TimeExecution.ExecutionTimes(times);

            Console.ReadKey();
        }
    }
}
