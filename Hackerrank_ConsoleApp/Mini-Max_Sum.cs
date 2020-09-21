using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Mini_Max_Sum
    {
        public void Main()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            var sumOfAllNumbers = 0L;
            var minimum = long.MaxValue;
            var maximum = 0L;

            for (int i = 0; i < arr.Length; i++)
            {
                sumOfAllNumbers += arr[i];
                if (arr[i] < minimum)
                    minimum = arr[i];

                if (arr[i] > maximum)
                    maximum = arr[i];
            }

            Console.WriteLine(string.Format("{0} {1}", sumOfAllNumbers - maximum, sumOfAllNumbers - minimum));

        }
    }
}
