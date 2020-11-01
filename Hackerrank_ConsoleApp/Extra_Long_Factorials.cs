using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Hackerrank_ConsoleApp
{
    class Extra_Long_Factorials
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            extraLongFactorials(n);
        }

        // Complete the extraLongFactorials function below.
        static void extraLongFactorials(int n)
        {
            var factorial = System.Numerics.BigInteger.One;
            for (int i = 1; i <= n; i++)
                factorial = factorial * i;

            Console.WriteLine(factorial);
        }
    }
}
