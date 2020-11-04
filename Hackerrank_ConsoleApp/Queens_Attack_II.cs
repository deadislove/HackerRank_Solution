using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Queens_Attack_II
    {
        /* Problem link: https://www.hackerrank.com/challenges/queens-attack-2/problem
         */

        public void Main()
        {
            string[] nk = Console.ReadLine().Split(' ');
            //n: an integer, the number of rows and columns in the board
            int n = Convert.ToInt32(nk[0]);
            //k: an integer, the number of obstacles on the board
            int k = Convert.ToInt32(nk[1]);
            
            string[] r_qC_q = Console.ReadLine().Split(' ');
            //r_q: integer, the row number of the queen's position
            int r_q = Convert.ToInt32(r_qC_q[0]);
            //c_q: integer, the column number of the queen's position
            int c_q = Convert.ToInt32(r_qC_q[1]);
            //obstacles: a two dimensional array of integers where each element is an array of 2 integers, the row and column of an obstacle
            int[][] obstacles = new int[k][];

            for (int i = 0; i < k; i++)
            {
                obstacles[i] = Array.ConvertAll(Console.ReadLine().Split(' '), obstaclesTemp => Convert.ToInt32(obstaclesTemp));
            }

            int result = queensAttack(n, k, r_q, c_q, obstacles);

            Console.WriteLine(result);
        }

        // Complete the queensAttack function below.
        int queensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            int leftTop = Math.Min(n - r_q, c_q - 1);
            int top = n - r_q;
            int rightTop = Math.Min(n - r_q, n - c_q);
            int right = n - c_q;
            int rightDown = Math.Min(r_q - 1, n - c_q);
            int down = r_q - 1;
            int leftDown = Math.Min(r_q - 1, c_q - 1);
            int left = c_q - 1;

            int length = 0;
            foreach (var item in obstacles)
            {
                if (item[0] > r_q)
                {
                    if (item[0] - r_q == c_q - item[1])//Left top
                    {
                        length = item[0] - r_q;
                        if (leftTop > length)
                        {
                            leftTop = length - 1;
                        }
                    }
                    if (item[1] == c_q)//Top
                    {
                        length = item[0] - r_q;
                        if (top > length)
                        {
                            top = length - 1;
                        }
                    }
                    if (item[0] - r_q == item[1] - c_q)//right top
                    {
                        length = item[0] - r_q;
                        if (rightTop > length)
                        {
                            rightTop = length - 1;
                        }
                    }
                }

                if (item[0] == r_q && item[1] > c_q)//right
                {
                    length = item[1] - c_q;
                    if (right > length)
                    {
                        right = length - 1;
                    }
                }

                if (item[0] < r_q)
                {
                    if (r_q - item[0] == item[1] - c_q)//right bottom
                    {
                        length = r_q - item[0];
                        if (rightDown > length)
                        {
                            rightDown = length - 1;
                        }
                    }
                    if (item[1] == c_q)//下
                    {
                        length = r_q - item[0];
                        if (down > length)
                        {
                            down = length - 1;
                        }
                    }
                    if (r_q - item[0] == c_q - item[1])//left bottom
                    {
                        length = r_q - item[0];
                        if (leftDown > length)
                        {
                            leftDown = length - 1;
                        }
                    }
                }


                if (item[0] == r_q && item[1] < c_q)//left
                {
                    length = c_q - item[1];
                    if (left > length)
                    {
                        left = length - 1;
                    }
                }
            }

            return leftTop + top + rightTop + right + rightDown + down + leftDown + left;
        }
    }
}
