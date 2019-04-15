using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    public static class DeadAnts
    {
        /// <summary>
        /// Kata - Dead Ants
        /// 
        /// An orderly trail of ants is marching across the park picnic area.
        /// 
        /// It looks something like this:
        /// 
        /// ..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..
        /// 
        /// But suddenly there is a rumour that a dropped chicken sandwich has been spotted on the ground ahead.
        /// The ants surge forward! Oh No, it's an ant stampede!!
        /// 
        /// Some of the slower ants are trampled, and their poor little ant bodies are broken up into scattered bits.
        ///
        /// The resulting carnage looks like this:
        /// 
        /// ...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t
        ///
        /// Can you find how many ants have died?
        ///
        /// https://www.codewars.com/kata/dead-ants/csharp
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int DeadAntsCount(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;
            input = input.ToLower();

            var bodyPartCount = GetBodyPartsCounts(input);

            var antsCount = GetAliveAntsCount(input);

            var deadAntsCount = bodyPartCount.Values.Max() - antsCount;

            return deadAntsCount;
        }

        private static int GetAliveAntsCount(string input)
        {
            int antsCount = 0;

            int startIndex = 0;
            while (true)
            {
                var resultIndex = 0;
                if ((resultIndex = input.IndexOf("ant", startIndex)) >= 0)
                {
                    antsCount++;
                    startIndex = resultIndex + 1;
                }
                else
                {
                    break;
                }
            }

            return antsCount;
        }

        private static Dictionary<char, int> GetBodyPartsCounts(string input)
        {
            var counts = new Dictionary<char, int>()
            {
                {'a', 0},
                {'n', 0},
                {'t', 0}
            };

            foreach (var character in input)
            {
                if (counts.ContainsKey(character))
                {
                    counts[character]++;
                }
            }

            return counts;
        }
    }
}