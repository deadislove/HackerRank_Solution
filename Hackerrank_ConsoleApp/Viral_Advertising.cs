using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Viral_Advertising
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }

        // Complete the viralAdvertising function below.
        static int viralAdvertising(int n)
        {
            int First = 5;
            int iCount = 0;
            while (n > 0)
            {
                int interested = First / 2;
                First = interested * 3;
                iCount = iCount + interested;
                n--;
            }

            return iCount;
        }
    }
}
