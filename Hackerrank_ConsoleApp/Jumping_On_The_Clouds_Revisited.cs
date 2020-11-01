using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Jumping_On_The_Clouds_Revisited
    {
        public void Main()
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));
            int result = jumpingOnClouds(c, k);

            Console.WriteLine(result);
        }

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c, int k)
        {
            int e = 100;
            int pos = 0;
            while (true)
            {
                pos = (pos + k) % c.Count();

                if (c[pos] == 1)
                    e -= 3;
                else
                    e--;

                if (pos == 0)
                    break;
            }

            return e;

        }
    }
}
