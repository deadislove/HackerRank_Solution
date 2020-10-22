using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Sales_by_Match
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (ar[i] != 0)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (ar[i].Equals(ar[j]))
                        {
                            ++count;
                            ar[j] = 0;
                            break;
                        }
                    }
                }
            }

            return count;
        }
    }
}
