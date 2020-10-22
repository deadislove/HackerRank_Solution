using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Forming_A_Magic_Square
    {
        public void Main()
        {           

            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
        }

        static int formingMagicSquare(int[][] s)
        {
            List<int[,]> squares = new List<int[,]>
            {
                square1,
                square2,
                square3,
                square4,
                square5,
                square6,
                square7,
                square8
            };
            
            int min = int.MaxValue;

            for (var S = 0; S < squares.Count; S++)
            {
                int tempMin = 0;
                for (int i = 0; i < 3 && tempMin < min; i++)
                {
                    for (int j = 0; j < 3 && tempMin < min; j++)
                    {
                        tempMin += Math.Abs(s[i][j] - squares[S][i, j]);
                    }
                }

                min = tempMin < min ? tempMin : min;
            }

            //Console.WriteLine(min);

            return min;
        }

        static int[,] square1 = {
            { 8, 1, 6 },
            { 3, 5, 7 },
            { 4, 9, 2 }
        };
        static int[,] square2 = {
            { 8, 3, 4 },
            { 1, 5, 9 },
            { 6, 7, 2 }
        };
        static int[,] square3 = {
            { 6, 7, 2 },
            { 1, 5, 9 },
            { 8, 3, 4 }
        };
        static int[,] square4 = {
            { 4, 9, 2 },
            { 3, 5, 7 },
            { 8, 1, 6 }
        };
        static int[,] square5 = {
            { 2, 9, 4 },
            { 7, 5, 3 },
            { 6, 1, 8 }
        };
        static int[,] square6 = {
            { 2, 7, 6 },
            { 9, 5, 1 },
            { 4, 3, 8 }
        };
        static int[,] square7 = {
            { 4, 3, 8 },
            { 9, 5, 1 },
            { 2, 7, 6 }
        };
        static int[,] square8 = {
            { 6, 1, 8 },
            { 7, 5, 3 },
            { 2, 9, 4 }
        };
    }
}
