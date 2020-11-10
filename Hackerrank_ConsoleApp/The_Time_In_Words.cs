using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class The_Time_In_Words
    {
        public void Main()
        {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
        }

        // Complete the timeInWords function below.
        static string timeInWords(int h, int m)
        {
            var hourWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven" };
            var minuteWords = new[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten"
                                    , "eleven", "twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen","twenty"
                                    , "twenty one", "twenty two", "twenty three", "twenty four", "twenty five", "twenty six", "twenty seven", "twenty eight","twenty nine" };
            if (m == 0)
                return ($"{hourWords[h - 1]} o' clock").ToString();
            //Console.Write($"{hourWords[h - 1]} o' clock");

            if ((m > 0 && m < 15) || (m > 15 && m < 30))
            {
                if(m == 1)
                    return ($"{minuteWords[m - 1]} minute past {hourWords[h - 1]}").ToString();
                else
                    return ($"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}").ToString();
                //Console.Write($"{minuteWords[m - 1]} minutes past {hourWords[h - 1]}");
            }
            
            if ((m > 30 && m < 45) || (m > 45 && m < 60))
                return ($"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}").ToString();
            //Console.Write($"{minuteWords[60 - m - 1]} minutes to {hourWords[h]}");

            if (m == 15)
                return ($"quarter past {hourWords[h - 1]}").ToString();
            //Console.Write($"quarter past {hourWords[h - 1]}");

            if (m == 30)
                return ($"half past {hourWords[h - 1]}").ToString();
            //Console.Write($"half past {hourWords[h - 1]}");

            if (m == 45)
                return ($"quarter to {hourWords[h]}").ToString();
            //Console.Write($"quarter to {hourWords[h]}");

            return string.Empty;

        }
    }
}
