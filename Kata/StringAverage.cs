using System;
using System.Linq;
using System.Threading;

namespace Kata
{
    public class StringAverage
    {
        public static string AverageString(string input)
        {
            var error = "n/a";

            if (input == string.Empty)
                return error;
            if (input.Split(" ").Length == 0)
                return error;

            try
            {
                var average = input.Split(" ")
                    .ToList()
                    .Select(x => x.TextToInt())
                    .Average();
                return ((int) Math.Floor(average)).IntToText();
            }
            catch (ArgumentOutOfRangeException)
            {
                return error;
            }
        }
    }

    public static class Extensions
    {
        private static readonly string[] Words = new string[]
        {
            "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine"
        };

        public static int TextToInt(this string input)
        {
            if(Words.Contains(input)!=true)
                throw new ArgumentOutOfRangeException();
            return Array.IndexOf(Words, input);
        }


        public static string IntToText(this int input)
        {
            if (input < 0 || input > Words.Length - 1)
                throw new AbandonedMutexException();
            return Words[input];
        }
    }
}
