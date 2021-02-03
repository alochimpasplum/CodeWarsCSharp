using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu8
{
    public static class GradeBook
    {
        // https://www.codewars.com/kata/55cbd4ba903825f7970000f5/train/csharp
        public static char GetGrade(int s1, int s2, int s3)
        {
            double med = (s1 + s2 + s3) / 3;
            return (med >= 90) ? 'A' : (med >= 80) ? 'B' : (med >= 70) ? 'C' : (med >= 60) ? 'D' : 'F';
        }
    }
}
