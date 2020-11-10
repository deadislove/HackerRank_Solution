using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Modified_Kaprekar_Numbers
    {
        public void Main()
        {
            int p = Convert.ToInt32(Console.ReadLine());

            int q = Convert.ToInt32(Console.ReadLine());

            kaprekarNumbers(p, q);
        }

        // Complete the kaprekarNumbers function below.
        static void kaprekarNumbers(int p, int q)
        {
            var result = new List<int>();

            for (var i = p; i < q + 1; i++)
            {
                if (IsKaprekar(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(!result.Any() ? "INVALID RANGE" : string.Join(" ", result));
        }

        private static bool IsKaprekar(int i)
        {
            // how many digits?
            int magnitude = (int)Math.Floor(Math.Log10(i) + 1);

            double square = Math.Pow(i, 2);

            // get right digits
            double r = square % Math.Pow(10, magnitude);

            // get left digits
            double l = square / Math.Pow(10, magnitude);

            return (int)(l + r) == i;
        }
    }
}
