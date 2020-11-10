using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Halloween_Sale
    {
        public void Main()
        {            
            string[] pdms = Console.ReadLine().Split(' ');

            int p = Convert.ToInt32(pdms[0]);

            int d = Convert.ToInt32(pdms[1]);

            int m = Convert.ToInt32(pdms[2]);

            int s = Convert.ToInt32(pdms[3]);

            int answer = howManyGames(p, d, m, s);

            Console.WriteLine(answer);
            
        }

        // Complete the howManyGames function below.
        static int howManyGames(int p, int d, int m, int s)
        {
            // Return the number of games you can buy
            int iCount = 0;
            while (s >= p) {
                iCount++;
                s -= p;
                p = Math.Max(p - d, m);
            }

            return iCount;
        }
    }
}
