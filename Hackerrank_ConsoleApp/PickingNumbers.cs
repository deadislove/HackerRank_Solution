using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class PickingNumbers
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = pickingNumbers(a.OrderBy(x=>x).ToList());

            Console.WriteLine(result);
        }

        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        public static int pickingNumbers(List<int> a)
        {
            int maxCount = 0;
            for (int i = 0; i < a.Count(); i++)
            {
                //if (i > 0)
                //    if (a[i] == a[i - 1])
                //        continue;

                var countCount = 1;
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (Math.Abs(a[j] - a[i]) <= 1)
                    {
                        countCount++;
                    }
                    else
                        break;
                }

                if (countCount > maxCount)
                    maxCount = countCount;
            }

            return maxCount;
        }
    }
}
