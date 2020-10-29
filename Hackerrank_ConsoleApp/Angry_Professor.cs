using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Angry_Professor
    {
        public void Main()
        {            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);
                //k: the threshold number of students
                int k = Convert.ToInt32(nk[1]);
                //a: an array of integers representing arrival times
                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                string result = angryProfessor(k, a);

                Console.WriteLine(result);
            }

        }

        // Complete the angryProfessor function below.
        static string angryProfessor(int k, int[] a)
        {
            var onTime = 0;
            foreach (var Item in a)
            {
                if (Item <= 0)
                    onTime++;

                if (onTime == k)
                    break;
            }

            return onTime < k ? "YES" : "NO";
        }
    }
}
