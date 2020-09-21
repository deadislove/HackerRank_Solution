using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class TimeConversion
    {
        public void Main()
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);
        }

        /*
        * Complete the timeConversion function below.
        */
        static string timeConversion(string s)
        {
            /*
             * Write your code here.
             */
            DateTime d = DateTime.Parse(s);
            

            return d.ToString("HH:mm:ss");

        }
    }
}
