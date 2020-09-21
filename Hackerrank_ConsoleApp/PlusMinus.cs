using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class PlusMinus
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            plusMinus(arr,n);
        }

        static void plusMinus(int[] arr,int n)
        {
            int[] filiter = new int[] {
                (from a in arr where a > 0 select a).Count(),
                (from a in arr where a < 0 select a).Count(),
                (from a in arr where a == 0 select a).Count()
            };
            
            for (int i = 0; i < filiter.Length; i++)
            {
                Console.WriteLine("{0:F6}", filiter[i] / (n * 1.0));
            }

        }
    }
}
