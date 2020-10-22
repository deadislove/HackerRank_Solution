using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Strange_Counter
    {
        public void Main()
        {   
            long t = Convert.ToInt64(Console.ReadLine());

            long result = strangeCounter(t);

            Console.WriteLine(result);
        }

        // Complete the strangeCounter function below.
        static long strangeCounter(long t)
        {
            long v = 4;

            while (v <= t)
            {
                v = v * 2 + 2;
            }
            return v - t;
        }
    }
}
