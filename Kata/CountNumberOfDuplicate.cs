using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Kata
{

    public static class CountNumberOfDuplicate
    {
        public static int DuplicateCount(string input)
        {
            return input.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
        }
    }

    public static class CountNumberOfDuplicateOld
    {
        public static int DuplicateCount(string input)
        {
            var counts = new Dictionary<char, int>();
            foreach (char c in input.ToLower())
            {
                if (counts.ContainsKey(c))
                {
                    counts[c]++;
                }
                else
                {
                    counts.Add(c, 1);
                }
            }

            return counts.Values.Count(x => x > 1);
        }
    }
}