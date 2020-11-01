using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Append_And_Delete
    {
        public void Main()
        {
            string s = Console.ReadLine();

            string t = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine());

            string result = appendAndDelete(s, t, k);

            Console.WriteLine(result);
        }

        // Complete the appendAndDelete function below.
        static string appendAndDelete(string s, string t, int k)
        {
            //Case 1.
            if (s.Length + t.Length <= k)
                return "YES";

            //Case 2.
            int i = 0;
            for (i = 0; i < s.Length && i < t.Length; i++)
            {
                if (s[i] != t[i])
                    break;
            }

            int minOperations = (s.Length - i) + (t.Length - i);
            if (k >= minOperations && (k - minOperations) % 2 == 0)
                return "YES";
            else
                return "NO";
        }
    }
}
