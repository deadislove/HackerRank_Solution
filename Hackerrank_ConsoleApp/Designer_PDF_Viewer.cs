using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Designer_PDF_Viewer
    {
        public void Main()
        {
            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp))
            ;
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);
        }

        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            var alphabetHeight = new Dictionary<char, int>();

            var alphabet = 'a';
            foreach (var height in h)
            {
                alphabetHeight.Add(alphabet++, height);
            }

            var maxAlphabetHeight = 0;
            foreach (var letter in word)
            {
                if (alphabetHeight[letter] > maxAlphabetHeight)
                {
                    maxAlphabetHeight = alphabetHeight[letter];
                }
            }

            var areaOfSelectedText = maxAlphabetHeight * word.Length;

            return areaOfSelectedText;
        }
    }
}
