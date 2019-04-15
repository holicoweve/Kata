using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public static class BandNameGenerators
    {
        public static string BandNameGenerator(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            input = input.ToLower();

            if (input.Length == 1 || !StartsAndEndSameLetter(input))
            {
                return TheAndCapitalize(input);
            }
            else
            {
                return RepeatTwice(input);
            }
        }

        private static bool StartsAndEndSameLetter(string input)
        {
            return input[0] == input[input.Length - 1];
        }
        private static string TheAndCapitalize(string input)
        {
            return "The " + Capitalize(input);
        }

        private static string RepeatTwice(string input)
        {
            return Capitalize(input+input.Substring(1));
        }

        private static string Capitalize(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
