using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Circular_Array_Rotation
    {
        public void Main()
        {            
            string[] nkq = Console.ReadLine().Split(' ');
            //number Of Elements 
            int n = Convert.ToInt32(nkq[0]);
            //number Of Rotations  
            int k = Convert.ToInt32(nkq[1]);
            //number Of Queries
            int q = Convert.ToInt32(nkq[2]);
            // input number.
            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            int[] queries = new int[q];

            for (int i = 0; i < q; i++)
            {
                int queriesItem = Convert.ToInt32(Console.ReadLine());
                queries[i] = queriesItem;
            }

            int[] result = circularArrayRotation(a, k, queries);

            Console.WriteLine(string.Join("\n", result));
        }

        // Complete the circularArrayRotation function below.
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] result = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                result[(i + k) % a.Length] = a[i];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = result[queries[i]];
            }

            return queries;
        }
    }
}
