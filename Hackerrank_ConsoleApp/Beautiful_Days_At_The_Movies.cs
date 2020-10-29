using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Beautiful_Days_At_The_Movies
    {
        public void Main()
        {  
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }

        // Complete the beautifulDays function below.
        static int beautifulDays(int i, int j, int k)
        {
            var bDays = 0;

            for (int c = i; c <= j; c++)
            {
                var reverseString = new string(c.ToString().Reverse().ToArray());
                var reverseNumber = int.Parse(reverseString);
                var d = Math.Abs(c - reverseNumber);
                var r = d % k;

                if (r == 0)
                    bDays++;
            }

            return bDays;
        }
    }
}
