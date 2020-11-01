using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Find_Digits
    {
        public void Main()
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }

        // Complete the findDigits function below.
        static int findDigits(int n)
        {
            int iCount = 0;

            string sValue = n.ToString();
            foreach (var item in sValue)
            {
                if (item == '0')
                    continue;

                if (n % (int)char.GetNumericValue(item) == 0)
                    iCount++;
            }

            return iCount;
        }
    }
}