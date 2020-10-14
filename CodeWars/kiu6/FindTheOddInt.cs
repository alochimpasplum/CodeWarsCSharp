using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    static class FindTheOddInt
    {
        private static List <Number> Numbers { get; set; }
        public static int find_it(int[] seq)
        {
            Numbers = new List<Number>();
            int number = 0;

            foreach(int i in seq)
            {
                if (Numbers.Any(x => x.index == i))
                {
                    Numbers.Find(x => x.index == i).repeats++;
                } else
                {
                    Numbers.Add(new Number(i));
                }
            }
            foreach(Number n in Numbers)
            {
                if (n.repeats % 2 != 0) { number = n.index; }
            }
            return number;
        }

        public static int betterSol(int[] seq)
        {
            return seq.GroupBy(x => x).Single(g => g.Count() % 2 == 1).Key;
        }
    }

    class Number
    {
        public int index { get; set; }
        public int repeats { get; set; }
        public Number(int number)
        {
            index = number;
            repeats = 1;
        }
    }
}
