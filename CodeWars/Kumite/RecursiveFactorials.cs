using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Kumite
{
    public static class RecursiveFactorials
    {
        public static int Kata(long n)
        {
            int i = 1;
            if (n != 0)
            {
                while (n / i != 1)
                {
                    n /= i;
                    i++;
                }
            } else
            {
                n = i;
            }
            return (int) n;
        }
    }
}

//Factorial de 0, 1
//Factorial de 1, 1
//Factorial de 2, 2
//Factorial de 3, 6
//Factorial de 4, 24
//Factorial de 5, 120
//Factorial de 6, 720
//Factorial de 7, 5040
//Factorial de 8, 40320
//Factorial de 9, 362880
//Factorial de 10, 3628800
//Factorial de 11, 39916800
//Factorial de 12, 479001600
//Factorial de 13, 6227020800
//Factorial de 14, 87178291200
//Factorial de 15, 1307674368000
//Factorial de 16, 20922789888000
//Factorial de 17, 355687428096000
//Factorial de 18, 6402373705728000
//Factorial de 19, 121645100408832000
//Factorial de 20, 2432902008176640000