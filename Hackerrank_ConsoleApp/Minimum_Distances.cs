using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Minimum_Distances
    {
        public void Main()
        {            
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = minimumDistances(a);

            Console.WriteLine(result);            
        }

        // Complete the minimumDistances function below.
        static int minimumDistances(int[] a)
        {
            var minmumDis = -1;
            var numberMap = new Dictionary<int, int>();

            for (var i = 0; i < a.Length; i++)
            {
                if (numberMap.ContainsKey(a[i]))
                {
                    if (minmumDis == -1)
                    {
                        minmumDis = i - numberMap[a[i]];
                        continue;
                    }

                    if (i - numberMap[a[i]] < minmumDis)
                        minmumDis = i - numberMap[a[i]];
                }
                else
                    numberMap.Add(a[i], i);
            }

            return minmumDis;
        }
    }
}
