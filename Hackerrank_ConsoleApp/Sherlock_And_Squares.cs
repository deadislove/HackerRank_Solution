using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Sherlock_And_Squares
    {
        public void Main()
        {            
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
        }

        // Complete the squares function below.
        static int squares(int a, int b)
        {
            int squareInt = 0;

            //Finds our starting squareInteger
            int iStart = (int)Math.Sqrt(a);
            //Finds our ending squareInteger
            int iEnd = (int)Math.Sqrt(b);

            //Calculates the squareIntegers between them
            squareInt = iEnd - iStart;

            //Checks to make sure we didn't forget one when we floored A
            squareInt += (Math.Pow(iStart, 2) >= a) ? 1 : 0;

            return squareInt;
        }
    }
}
