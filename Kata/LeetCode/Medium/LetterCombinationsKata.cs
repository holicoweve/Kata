using System.Collections.Generic;

namespace Kata.LeetCode.Medium
{
	/// <summary>
	/// Letter Combinations of a Phone Number
	///
	/// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
	/// </summary>
	public class LetterCombinationsKata
	{
		private readonly string[] _conversionMaps = { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

		public IList<string> LetterCombinations(string digits)
		{
			var returnValue = new List<string>() { string.Empty };
			var tempList = new List<string>();

			foreach (var digit in digits)
			{
				if (digit > '9' || digit < '0')
					continue;
				var multiplier = _conversionMaps[int.Parse(digit.ToString())];
				foreach (var charChoice in multiplier)
				{
					foreach (var returnString in returnValue)
					{
						tempList.Add(returnString + charChoice);
					}
				}
				returnValue.Clear();
				returnValue.AddRange(tempList);
				tempList.Clear();
			}

			returnValue.Remove(string.Empty);
			return returnValue;
		}
	}
}