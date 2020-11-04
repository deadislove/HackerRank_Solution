using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class ACM_ICPC_Team
    {
        public void Main()
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            string[] topic = new string[n];

            for (int i = 0; i < n; i++)
            {
                string topicItem = Console.ReadLine();
                topic[i] = topicItem;
            }

            int[] result = acmTeam(topic);

            Console.WriteLine(string.Join("\n", result));

        }

        // Complete the acmTeam function below.
        static int[] acmTeam(string[] topic)
        {
            int maxSkills = 0;
            int maxSkillTeams = 0;

            for (int i = 0; i < topic.Length; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    String member1 = topic[i];
                    String member2 = topic[j];
                    int skillSet = 0;

                    for (int k = 0; k < topic[i].Length; k++)
                    {
                        if (member1[k] == '1' || member2[k] == '1')
                        {
                            skillSet++;
                        }
                    }

                    maxSkillTeams += (maxSkills == skillSet) ? 1 : 0;

                    if (skillSet > maxSkills)
                    {
                        maxSkillTeams = 1;
                        maxSkills = skillSet;
                    }
                }
            }

            return new int[] {maxSkills,maxSkillTeams };
        }
    }
}
