using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Breaking_the_Records
    {
        public void Main()
        {
            

            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
                        
        }

        static int[] breakingRecords(int[] scores)
        {
            var minRecordBroken = 0;
            var maxRecordBroken = 0;

            if (scores.Length > 1)
            {
                var minRecord = scores[0];
                var maxRecord = scores[0];

                for (int i = 1; i < scores.Length; i++)
                {
                    if (scores[i] < minRecord)
                    {
                        minRecord = scores[i];
                        minRecordBroken++;
                    }

                    if (scores[i] > maxRecord)
                    {
                        maxRecord = scores[i];
                        maxRecordBroken++;
                    }
                }
            }
            return new int[] { maxRecordBroken, minRecordBroken };
        }
    }
}
