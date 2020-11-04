using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Taum_And_B_day
    {
        /* Problem link: https://www.hackerrank.com/challenges/taum-and-bday/problem
         */
        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                //b: the number of black gifts
                int b = Convert.ToInt32(firstMultipleInput[0]);

                //w: the number of white gifts
                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                //bc: the cost of a black gift
                int bc = Convert.ToInt32(secondMultipleInput[0]);

                //wc: the cost of a white gift
                int wc = Convert.ToInt32(secondMultipleInput[1]);

                //z: the cost to convert one color gift to the other color
                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }
        /*
         * Complete the 'taumBday' function below.
        *
        * The function is expected to return a LONG_INTEGER.
        * The function accepts following parameters:
        *  1. INTEGER b
        *  2. INTEGER w
        *  3. INTEGER bc
        *  4. INTEGER wc
        *  5. INTEGER z
        */

        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            long result = 0L;
            result = b * (long)Math.Min(bc, wc + z) + w * (long)Math.Min(wc, bc + z);
            return result;
        }

    }
}
