using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Service_Lane
    {
        public void Main()
        {
            string[] nt = Console.ReadLine().Split(' ');

            //n: an integer denoting the size of the cases  array
            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;
            //cases: a two dimensional array of integers where each element is an array of two integers representing starting and ending indices for a segment to consider .
            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = serviceLane(width, cases);

            Console.WriteLine(string.Join("\n", result));
        }

        // Complete the serviceLane function below.
        static int[] serviceLane(int[] serviceLaneWidths, int[][] cases)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < cases.Length; i++)
            {
                var entryIndex = cases[i][0];
                var exitIndex = cases[i][1];

                var minWidth = 3;

                for (int j = entryIndex; j <= exitIndex; j++)
                {
                    if (serviceLaneWidths[j] < minWidth)
                        minWidth = serviceLaneWidths[j];

                    //a portion of service lane is allowing only bikes so no more traversal is required.
                    if (minWidth == 1)
                        break;
                }

                result.Add(minWidth);
            }

            return result.ToArray();
        }

    }
}
