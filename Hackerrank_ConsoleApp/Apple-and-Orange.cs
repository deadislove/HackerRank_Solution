using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Apple_and_Orange
    {
        public void Main()
        {
            string[] st = Console.ReadLine().Split(' ');

            //s: integer, starting point of Sam's house location.
            int s = Convert.ToInt32(st[0]);

            //t: integer, ending location of Sam's house location.
            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            //a: integer, location of the Apple tree.
            int a = Convert.ToInt32(ab[0]);

            //b: integer, location of the Orange tree.
            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            //The fourth line contains m  space-separated integers denoting the respective distances that each apple falls from point .
            int m = Convert.ToInt32(mn[0]);

            //The fifth line contains  space - separated integers denoting the respective distances that each orange falls from point.
            int n = Convert.ToInt32(mn[1]);

            //apples: integer array, distances at which each apple falls from the tree.
            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            //oranges: integer array, distances at which each orange falls from the tree.
            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;

            /* 
             */

            countApplesAndOranges(s, t, a, b, apples, oranges, m, n);
        }

        static void countApplesAndOranges(int s, int t, int a, int b, int[] apple, int[] orange,int m,int n)
        {
            int apples = 0;
            for (int i = 0; i < m; i++)
            {
                if (a + apple[i] >= s && a + apple[i] <= t) apples++;
            }
            int oranges = 0;
            for (int i = 0; i < n; i++)
            {
                if (b + orange[i] >= s && b + orange[i] <= t) oranges++;
            }
            Console.WriteLine(apples);
            Console.WriteLine(oranges);
        }
    }
}
