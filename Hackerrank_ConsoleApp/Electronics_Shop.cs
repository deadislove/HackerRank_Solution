using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Electronics_Shop
    {
        public void Main()
        {
            string[] bnm = Console.ReadLine().Split(' ');
            //int b: the budget
            int b = Convert.ToInt32(bnm[0]);
            //int keyboards[n]: the keyboard prices
            int n = Convert.ToInt32(bnm[1]);
            //int drives[m]: the drive prices
            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }

        /*
         * Complete the getMoneySpent function below.
         */
        public static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */

            var sortKB = from keyboard in keyboards
                         orderby keyboard descending
                         select keyboard;
            var sortD = from drive in drives
                        orderby drive ascending
                        select drive;
            var maxMoneySpendable = -1;

            foreach (var KeyboardItem in sortKB)
            {
                foreach (var driveItem in sortD)
                {
                    if (KeyboardItem + driveItem <= b)
                    {
                        if (KeyboardItem + driveItem > maxMoneySpendable)
                            maxMoneySpendable = KeyboardItem + driveItem;
                    }
                    else
                        break;
                }
            }

            return maxMoneySpendable;
        }
    }
}
