using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Non_Divisible_Subset
    {
        public void Main()
        {            
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            int result = nonDivisibleSubset(k, s);

            Console.WriteLine(result);
        }
        /*
         * Complete the 'nonDivisibleSubset' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER k
         *  2. INTEGER_ARRAY s
         */
        int nonDivisibleSubset(int k, List<int> s)
        {
            // Array for storing  
            // frequency of modulo values 
            int[] a = new int[k];

            for (int i = 0; i < k; i++)
                a[i] = 0;

            // Fill frequency array with values modulo K
            for (int i = 0; i < s.Count(); i++)
                a[s[i] % k]++;

            // if K is even, then update a[K/2]
            if (k % 2 == 0)
                a[k / 2] = Math.Min(a[k / 2], 1);

            // Initialize result by minimum of 1 or 
            // count of numbers giving remainder 0 
            int res = Math.Min(a[0], 1);

            // Choose maximum of count of numbers 
            // giving remainder i or K-i
            for (int i = 1; i <= k / 2; i++)
                res += Math.Max(a[i], a[k - i]);

            return res;
        }
    }
}
