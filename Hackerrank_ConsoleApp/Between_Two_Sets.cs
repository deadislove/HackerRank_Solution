using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Between_Two_Sets
    {
        public void Main()
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);
        }

        static int getTotalX(List<int> a, List<int> b)
        {
            var totalXs = 0;
            var maximumA = a.Max(); //Time-complexity O(n)
            var minimumB = b.Min(); //Time-complexity O(m)
            var counter = 1;
            var multipleOfMaxA = maximumA;

            while (multipleOfMaxA <= minimumB)
            {
                var factorOfAll = true;

                foreach (var item in a) //Time complexity O(n)
                {
                    if (multipleOfMaxA % item != 0)
                    {
                        factorOfAll = false;
                        break;
                    }
                }

                if (factorOfAll)
                {
                    foreach (var item in b) //Time complexity O(m)
                    {
                        if (item % multipleOfMaxA != 0)
                        {
                            factorOfAll = false;
                            break;
                        }
                    }
                }

                if (factorOfAll)
                    totalXs++;

                counter++;
                multipleOfMaxA = maximumA * counter; //Here counter is the x factor which contributes to O(x(n+m)) complexity.
            }
            return totalXs;
        }
    }
}
