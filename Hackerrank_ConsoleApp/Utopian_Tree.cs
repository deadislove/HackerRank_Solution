using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Utopian_Tree
    {
        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
        }

        // Complete the utopianTree function below.
        static int utopianTree(int n)
        {
            var finalSapling = 1;
            bool isSpring = true;

            while (n > 0)
            {
                if (isSpring)
                {
                    finalSapling *= 2;
                    isSpring = false;
                }
                else
                {
                    finalSapling++;
                    isSpring = true;
                }
                n--;
            }

            return finalSapling;

        }
    }
}
