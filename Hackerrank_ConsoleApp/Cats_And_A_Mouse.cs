using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Cats_And_A_Mouse
    {
        public void Main()
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }
        }

        // Complete the catAndMouse function below.
        static string catAndMouse(int x, int y, int z)
        {
            var a = Math.Abs(x - z);
            var b = Math.Abs(y - z);

            if (a < b)
                return "Cat A";
            else if (b < a)
                return "Cat B";
            else
                return "Mouse C";

        }
    }
}
