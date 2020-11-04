using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Jumping_On_The_Clouds
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            var emmasPosition = 0;
            var jumpCount = 0;
            while (true)
            {
                if (emmasPosition + 2 <= c.Length - 1 && c[emmasPosition + 2] == 0)
                    emmasPosition = emmasPosition + 2;
                else
                    emmasPosition++;

                jumpCount++;
                if (emmasPosition == c.Length - 1)
                    break;
            }

            return jumpCount;
        }
    }
}
