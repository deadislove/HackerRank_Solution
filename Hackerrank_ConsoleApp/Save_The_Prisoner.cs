using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Save_The_Prisoner
    {
        public void Main()
        {            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');
                //n: an integer, the number of prisoners
                int n = Convert.ToInt32(nms[0]);
                //m: an integer, the number of sweets
                int m = Convert.ToInt32(nms[1]);
                //s: an integer, the chair number to begin passing out sweets from
                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }

        /*
        Problem: https://www.hackerrank.com/challenges/save-the-prisoner/problem
        C# Language Version: 6.0
        Thoughts :
        1. Let the id of the prisoner from whom the sweet distribution begins is i.
        2. Let number of sweets to be distributed be n.
        3. Let total number of prisoners be m.
        4. Get the number of prisoners to be served starting from current value of i till the prisoner having highest prisoner Id. Let this number be p (= m - i + 1).
        5. If n is greater than p then 
            5.1 set i to 1.
            5.2 set n to n - p
            5.3 set n to n % m. Here % is remainder operator.
        6. If n is 0 then set i to m.
        6. If n is not equal to 0 then set i to i + n -1
        5. Print i
        Time Complexity:  O(1)
        Space Complexity: O(1)
        */

        // Complete the saveThePrisoner function below.
        static int saveThePrisoner(int n, int m, int s)
        {

            var remainingBeforeEnd = n - s + 1;
            if (m > remainingBeforeEnd)
            {
                s = 1;
                m -= remainingBeforeEnd;
                m = m % n;
            }

            if (m == 0)
                s = n;
            else
                s += m - 1;

            return s;
        }
    }
}
