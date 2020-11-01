using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Sequence_Equation
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));
            int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));
        }

        // Complete the permutationEquation function below.
        static int[] permutationEquation(int[] p)
        {
            int[] iResut = new int[p.Length];

            int[] indexArr = new int[p.Length];

            for (int i = 0; i < p.Length; i++)
            {
                int val = p[i];
                indexArr[val - 1] = i + 1;
            }

            for (int i = 0; i < p.Length; i++)
            {
                iResut[i] = indexArr[indexArr[i] - 1];
            }

            return iResut;
        }
    }
}