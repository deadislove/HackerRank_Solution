using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Staircase
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }

        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var spaces = new String(' ', n - i);
                var hashes = new String('#', i);
                Console.WriteLine(spaces + hashes);
            }

        }
    }
}
