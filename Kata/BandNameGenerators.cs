using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
    /// <summary>
    /// Kata - Band Name Generator
    ///
    /// My friend wants a new band name for her band. She like bands that use the formula:
    /// "The" + a noun with the first letter capitalized, for example:
    ///
    /// "dolphin" -> "The Dolphin"
    ///
    /// However, when a noun STARTS and ENDS with the same letter, she likes to repeat
    /// the noun twice and connect them together with the first and last letter, combined
    /// into one word (WITHOUT "The" in front), like this:
    ///
    /// "alaska" -> "Alaskalaska"
    ///
    /// Complete the function that takes a noun as a string, and returns her preferred band
    /// name written as a string.
    ///
    /// https://www.codewars.com/kata/band-name-generator/train/csharp
    /// </summary>
    public static class BandNameGenerators
    {
        public static string BandNameGenerator(string input)
        {
            if (string.IsNullOrEmpty(input))
                return null;
            input = input.ToLower();

            if (input.Length == 1 || !StartsAndEndSameLetter(input))
            {
                return "The " + Capitalize(input);
            }
            else
            {
                return Capitalize(input+input.Substring(1));
            }
        }

        private static bool StartsAndEndSameLetter(string input)
        {
            return input.First() == input.Last();
        }

        private static string Capitalize(string input)
        {
            return char.ToUpper(input.First()) + input.Substring(1);
        }
    }
}
