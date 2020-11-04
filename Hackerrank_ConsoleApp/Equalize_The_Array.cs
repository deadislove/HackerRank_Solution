using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Equalize_The_Array
    {
        public void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            int result = equalizeArray(arr);

            Console.WriteLine(result);
        }

        // Complete the equalizeArray function below.
        static int equalizeArray(int[] arr)
        {
            var hasMap = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (hasMap.ContainsKey(arr[i]))
                    hasMap[arr[i]]++;
                else
                    hasMap.Add(arr[i], 1);
            }

            var MaxFrequency = hasMap.Values.Max();

            return arr.Length - MaxFrequency;
        }
    }
}
