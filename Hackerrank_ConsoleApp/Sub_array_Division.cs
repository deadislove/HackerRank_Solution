using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Sub_array_Division
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }

        static int birthday(List<int> s, int d, int m)
        {
            int total = 0;
            for (int i = 0; i <= s.Count - m; i++)
            {
                var segsSum = s.GetRange(i, m).Aggregate((a, b) => a + b);
                if (segsSum == d)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
