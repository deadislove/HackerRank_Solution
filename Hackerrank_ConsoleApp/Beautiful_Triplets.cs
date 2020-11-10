using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Beautiful_Triplets
    {
        public void Main()
        {            
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = beautifulTriplets(d, arr);

            Console.WriteLine(result);
        }

        // Complete the beautifulTriplets function below.
        static int beautifulTriplets(int d, int[] arr)
        {
            int iCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (Array.Exists(arr, e => e == (arr[i] + d)) &&
                    Array.Exists(arr, e => e == (arr[i] + 2 * d))
                    )
                    iCount++;
                    
            }

            return iCount;
        }

        // Note: It will the double-value array problems.
        //static int beautifulTriplets(int d, int[] arr)
        //{
        //    int iCount = 0;

        //    var set = new HashSet<int>(arr);
        //    foreach (var item in set)
        //        if (set.Contains(item + d) && set.Contains(item + 2 * d))
        //            iCount++;

        //    return iCount;
        //}
    }
}
