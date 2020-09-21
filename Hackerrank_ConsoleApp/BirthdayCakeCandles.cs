using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class BirthdayCakeCandles
    {
        public void Main()
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = BirthdayCakeCandles_Result.birthdayCakeCandles(candles);
        }
    }

    class BirthdayCakeCandles_Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            #region My method
            //int result = 0;

            //var v = (from a in candles
            //          select new { values = a, count = a.ToString().Count() })
            //            .GroupBy(x => x.values)
            //            .Select(r => new
            //            {
            //                count = r.Sum(s => s.count)

            //            }).Max(max => max.count);
            //var t = (from a in candles
            //          select new { values = a, count = a.ToString().Count() }) 
            //            .GroupBy(x => x.values)
            //            .Select(r => new
            //            {
            //                count = r.Sum(s => s.count)
            //            }).ToList().Where(c => c.count != v).Count();

            //return result;
            #endregion

            //Better method
            int tallest = candles.Max();
            int count = candles.Count(c => c == tallest);
            Console.WriteLine(count);
            return count;
        }

    }
}
