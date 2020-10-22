using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Migratory_Birds
    {
        public void Main()
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

        // Complete the migratoryBirds function below.
        static int migratoryBirds(List<int> arr)
        {
            var birdTypeCounts = new int[arr.Count()];

            for (int i = 0; i < arr.Count(); i++)
                birdTypeCounts[arr[i] - 1]++;

            var maxBirdTypeCount = birdTypeCounts[0];
            var maxBirdType = 1;

            for (int i = 1; i < 5; i++)
            {
                if (birdTypeCounts[i] > maxBirdTypeCount)
                {
                    maxBirdTypeCount = birdTypeCounts[i];
                    maxBirdType = i + 1;
                }

                if (birdTypeCounts[i] == maxBirdTypeCount && i + 1 < maxBirdType)
                    maxBirdType = i + 1;
            }

            return maxBirdType;

        }
    }
}
