using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Bigger_Is_Greater
    {
        public void Main()
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                string w = Console.ReadLine();

                string result = biggerIsGreater(w);

                Console.WriteLine(result);
            }
        }

        // Complete the biggerIsGreater function below.
        string biggerIsGreater(string w)
        {
            for (int i = w.Length - 2; i >= 0; i--)
            {
                for (int j = w.Length - 1; j > i; j--)
                {
                    if (w[j] > w[i])
                    {
                        string result = "";
                        for (int k = 0; k < i; k++)
                        {
                            result += w[k];
                        }
                        result += w[j];
                        for (int t = w.Length - 1; t > i; t--)
                        {
                            if (t != j) result += w[t];
                            else result += w[i];
                        }
                        return result;
                    }
                }
            }
            return "no answer";
        }
    }
}
