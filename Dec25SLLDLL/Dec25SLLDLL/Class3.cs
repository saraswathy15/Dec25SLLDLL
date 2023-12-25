using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec25SLLDLL
{
    public class Class3
    {
        public static int BSearch(int[] arr, int target)
        {
            int minNum = 0;
            int maxNum = arr.Length - 1;
            int mid = (minNum + maxNum) / 2;
            while (minNum <= maxNum)
            {
                if (arr[mid] == target)
                { return mid + 1; }
                else if (target < arr[mid])
                {
                    maxNum = mid - 1; mid = (minNum + maxNum) / 2;
                }
                else { minNum = mid + 1; mid = (minNum + maxNum) / 2; }

                // return mid;
            }
            return -1;
        }
        public static int lSearch(int[] arr, int n, int target)
        {
            for (int i = 0; i < n; i++) { if (arr[i] == target) return i; }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] nums = { 33, 4, 55, 1, 99, 2, 0, 99 };
            // int x = 99;int result = lSearch(nums, nums.Length, x);
            //  if (result == -1) { Console.WriteLine("element nt found"); } else { Console.WriteLine(  "element is at position "+ result); }
            int ans = BSearch(nums, 9);
            if (ans == -1) { Console.WriteLine("not found"); } else { Console.WriteLine("yesss"); }
        }
    }
}


