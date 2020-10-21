using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class GradingStudents
    {
        public void Main()
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = GradingStudents.gradingStudents(grades);
            Console.WriteLine("\n result");
            Console.WriteLine(String.Join("\n", result));
        }

        static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count(); i++)
            {
                var item = Convert.ToInt32(grades[i]);
                if (item >= 38)
                {
                    var diff = 5 - (item % 5);
                    if (diff < 3)
                        grades[i] = item + diff;
                }
            }

            return grades;
        }
    }

    
}
