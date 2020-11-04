using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Encryption
    {
        public void Main()
        {
            string s = Console.ReadLine();

            string result = encryption(s);

            Console.WriteLine(result);
        }

        // Complete the encryption function below.
        static string encryption(string s)
        {
            var colCount = (int)Math.Ceiling(Math.Sqrt(s.Length));
            string sResult = string.Empty;


            for (int i = 0; i < colCount; i++)
            {
                var counter = 0;
                while (i + (counter * colCount) < s.Length)
                {
                    sResult += s[i + counter * colCount];
                    counter++;
                }
                sResult += " ";
            }

            return sResult;
        }
    }
}
