using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Chocolate_Feast
    {
        public void Main()
        {            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }
        }

        // Complete the chocolateFeast function below.
        static int chocolateFeast(int n, int c, int m)
        {
            var totalChocolate = n / c;
            var wrapperFromChocolates = totalChocolate;
            while (wrapperFromChocolates >= m)
            {
                totalChocolate += wrapperFromChocolates / m;
                wrapperFromChocolates = (wrapperFromChocolates / m) + (wrapperFromChocolates % m);
            }

            return totalChocolate;

        }
    }
}
