using System;
using System.Text.RegularExpressions;

namespace Kata
{
	/// <summary>
	/// String to Integer (atoi)
	/// https://leetcode.com/problems/string-to-integer-atoi/
	/// </summary>
	public class StringToIntegerAtoi
	{
		public int Atoi(string input)
		{
			int result = 0;
			input = input.Trim();
			var pattern = @"^[-+]?(\d+)";

			var match = Regex.Match(input, pattern);
			if (match.Success)
			{
				Int64.TryParse(match.Value, out var parseResult);
				var matchStr = match.Value;
				if (matchStr.StartsWith('-'))
				{
					matchStr = matchStr.Substring(0, 1) + matchStr.Substring(1).TrimStart('0');
				}
				matchStr = matchStr.TrimStart('+', '0');
				if ((matchStr.Length > 11 && matchStr.StartsWith('-')) || parseResult < int.MinValue)
					return int.MinValue;
				if (matchStr.Length > 11 || parseResult > int.MaxValue)
					return int.MaxValue;
				result = (int)parseResult;
			}

			return result;
		}
	}
}
