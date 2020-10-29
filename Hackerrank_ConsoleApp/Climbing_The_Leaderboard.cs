using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_ConsoleApp
{
    class Climbing_The_Leaderboard
    {
        public void Main()
        {
            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

            List<int> result = climbingLeaderboard(ranked, player);

            Console.WriteLine(String.Join("\n", result));

        }

        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
        {
            var defaultComparer = Comparer<int>.Default;
            var reverseComparer = Comparer<int>.Create((x, y) => -defaultComparer.Compare(x, y));
            var distinctOrderedScores = ranked.Distinct().OrderBy(i => i, reverseComparer).ToArray();

            return player
                .Select(i => Array.BinarySearch(distinctOrderedScores, i, reverseComparer))
                .Select(pos => (pos >= 0 ? pos : ~pos) + 1)
                .ToList();
        }

        /* Note: Here is a solution that utilizes BinarySearch. 
         * This method returns the index of the searched number in the array, or if the number is not found then it returns a negative number that is the bitwise complement of the index of the next element in the array. 
         * Binary search only works in sorted arrays. By Theodor Zoulias.
         */
    }
}
