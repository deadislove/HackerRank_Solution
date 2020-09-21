using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class DiagonalDifference
    {
        public void Main()
        {
            List<List<int>> collectionOfSeries = new List<List<int>>
                                {   new List<int>(){11,2,4},
                                    new List<int>(){4,5,6},
                                    new List<int>(){10,8,-12}
                                };

            Result.diagonalDifference(collectionOfSeries);
        }
    }

    class Result
    {

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

        public static int diagonalDifference(List<List<int>> arr)
        {
            //Convert to Jagged Arrays
            int[][] arrays = arr.Select(a => a.ToArray()).ToArray();

            //Convert to 2D array;
            int FirstDim = arrays.Length;
            int SecondDim = arrays.GroupBy(row => row.Length).Single().Key; // throws InvalidOperationException if source is not rectangular

            var result = new int[FirstDim, SecondDim];
            for (int i = 0; i < FirstDim; ++i)
                for (int j = 0; j < SecondDim; ++j)
                    result[i, j] = arrays[i][j];

            int d1 = 0, d2 = 0;
            int n = result.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    // finding sum of primary diagonal 
                    if (i == j)
                        d1 += result[i, j];

                    // finding sum of secondary diagonal 
                    if (i == n - j - 1)
                        d2 += result[i, j];
                }
            }
            int finalInt = Math.Abs(d1 - d2);
            return 0;
        }

    }
}
