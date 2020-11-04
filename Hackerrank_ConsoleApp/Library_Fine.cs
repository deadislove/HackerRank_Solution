using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Library_Fine
    {
        public void Main()
        {
            string[] d1M1Y1 = Console.ReadLine().Split(' ');

            int d1 = Convert.ToInt32(d1M1Y1[0]);

            int m1 = Convert.ToInt32(d1M1Y1[1]);

            int y1 = Convert.ToInt32(d1M1Y1[2]);

            string[] d2M2Y2 = Console.ReadLine().Split(' ');

            int d2 = Convert.ToInt32(d2M2Y2[0]);

            int m2 = Convert.ToInt32(d2M2Y2[1]);

            int y2 = Convert.ToInt32(d2M2Y2[2]);

            int result = libraryFine(d1, m1, y1, d2, m2, y2);

            Console.WriteLine(result);
        }

        // Complete the libraryFine function below.
        static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
        {
            var fine = 0;

            if (y1 > y2)
                fine = 10000;
            else if (y1 == y2)
            {
                if (m1 > m2)
                    fine = 500 * (m1 - m2);
                else if (m1==m2)
                {
                    if (d1 > d2)
                        fine = 15 * (d1 - d2);
                }
            }

            return fine;
        }
    }
}
