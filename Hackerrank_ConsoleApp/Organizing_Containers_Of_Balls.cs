using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Organizing_Containers_Of_Balls
    {
        /* Problem link: https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
         * 
         */

        public void Main()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[][] container = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
                }

                string result = organizingContainers(container);

                Console.WriteLine(result);
            }
        }

        // Complete the organizingContainers function below.
        string organizingContainers(int[][] container)
        {
            List<string> containerList = new List<string>();
            List<string> ballsList = new List<string>();
            int n = 0;
            n = container.Length;

            for (int i = 0; i < n; i++)
            {
                int iRowSum = 0;
                int iColSum = 0;

                for (int j = 0; j < n; j++)
                {
                    iRowSum += container[i][j];
                    iColSum += container[j][i];
                }

                ballsList.Add(iColSum.ToString());
                containerList.Add(iRowSum.ToString());
            }

            var result = containerList.Intersect(ballsList, StringComparer.InvariantCultureIgnoreCase);

            if (result.Any())
                return "Possible";
            else
                return "Impossible";

        }
    }
}
