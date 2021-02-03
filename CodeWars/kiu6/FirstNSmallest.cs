using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.kiu6
{
    public static class FirstNSmallest
    {
        // https://www.codewars.com/kata/5aec1ed7de4c7f3517000079/train/csharp
        public static int[] FirstNSmallestKata(int[] arr, int n)
        {
            List<int> nums = arr.ToList();

            while(nums.Count > n)
                nums.RemoveAt(nums.LastIndexOf(nums.Max()));

            return nums.ToArray();
        }
    }
}
