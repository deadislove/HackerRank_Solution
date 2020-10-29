using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class The_Hurdle_Race
    {
        public void Main()
        {            
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);
        }

        // Complete the hurdleRace function below.
        static int hurdleRace(int k, int[] height)
        {
            int iMax = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > iMax)
                    iMax = height[i];
            }

            return (iMax < k) ? 0 : iMax - k;
        }
    }
}
