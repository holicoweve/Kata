using System;
using System.Linq;

namespace Kata
{
	/// <summary>
	///     Kata - String Average
	///     You are given a string of numbers between 0-9.
	///     Find the average of these numbers and return it as a floored whole number (ie: no decimal places) written out as a
	///     string.
	///     Eg:
	///     "zero nine five two" -> "four"
	///     If the string is empty or includes a number greater than 9, return "n/a"
	/// 
	///     https://www.codewars.com/kata/string-average/train/csharp
	/// </summary>
	public class StringAverage
	{
		public string AverageString(string input)
		{
			var error = "n/a";

			if (input == string.Empty || input.Split(" ").Length == 0)
				return error;

			try
			{
				var average = input.Split(" ")
					.AsEnumerable()
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

	public static class StringAverageExtensions
	{
		private static readonly string[] Words =
		{
			"zero", "one", "two", "three", "four", "five",
			"six", "seven", "eight", "nine"
		};

		public static int TextToInt(this string input)
		{
			if (!Words.Contains(input))
				throw new ArgumentOutOfRangeException(nameof(input), "Only support input between zero to nine");
			return Array.IndexOf(Words, input);
		}

		public static string IntToText(this int input)
		{
			if (input < 0 || input > Words.Length - 1)
				throw new ArgumentOutOfRangeException(nameof(input), "Only support input between 0 to 9");
			return Words[input];
		}
	}
}