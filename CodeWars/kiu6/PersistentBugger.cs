using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class PersistentBugger
    {
        public static int Persistence(long n)
        {
            int i = 0;
            string number = n.ToString();

            while (number.ToString().Length != 1)
            {
                long numTemp = 1;

                foreach (char c in number)
                {
                    numTemp = numTemp * long.Parse(c.ToString());
                }

                number = numTemp.ToString();

                i++;
            }

            return i;
        }

        public static int PersistenceLinq(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }
    }
}
