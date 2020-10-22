using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Counting_Valleys
    {
        public void Main()
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = countingValleys(steps, path);

            Console.WriteLine(result);

        }

        static int countingValleys(int steps, string path)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'U')
                {
                    if (++sum == 0)
                        count++;
                }
                else
                    sum--;
            }

            return count;
        }
    }
}
