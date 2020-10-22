using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Drawing_Book
    {
        public void Main()
        {
            //int n: the number of pages in the book
            int n = Convert.ToInt32(Console.ReadLine());
            //int p: the page number to turn to
            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine(result);

        }

        /*
         * Complete the pageCount function below.
         */
        static int pageCount(int n, int p)
        {
            int totalPageTurnCountFromFront = n / 2;
            int targetPageTurnCountFromFront = p / 2;
            int targetPageTurnCountFromBack = totalPageTurnCountFromFront - targetPageTurnCountFromFront;

            return Math.Min(targetPageTurnCountFromFront, targetPageTurnCountFromBack);
        }
    }
}
