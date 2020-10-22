using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Bill_Division
    {
        public void Main()
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b, n);
        }

        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b,int n)
        {
            string sresult = string.Empty;
            int sum = 0;
            int iValue = 0;

            for (int i = 0; i < n; i++)
            {
                if (i != k)
                    sum = sum + bill[i];
            }

            iValue = sum / 2;
            if (iValue == b)
            {
                sresult = "Bon Appetit";
            }
            else
            {
                sresult = (b - iValue).ToString();
            }

            Console.WriteLine(sresult);
        }
    }
}
