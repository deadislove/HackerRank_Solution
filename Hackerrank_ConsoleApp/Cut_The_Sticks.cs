using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Cut_The_Sticks
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = cutTheSticks(arr);

            Console.WriteLine(string.Join("\n", result));
        }

        // Complete the cutTheSticks function below.
        static int[] cutTheSticks(int[] arr)
        {
            Array.Sort(arr);
            List<int> result = new List<int>
            {
                arr.Length
            };

            int iMin = arr[0];
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > iMin)
                {
                    iMin = arr[i];
                    result.Add(arr.Length - i);
                }
            }

            return result.ToArray();
        }
    }
}
