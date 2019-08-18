using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Kata
{
	/// <summary>
	/// Longest Substring Without Repeating Characters
	/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
	/// </summary>
	public class LongestSubstringWithoutRepeat
	{
		internal string LongestSubstring(string input)
		{
			if (input.Length == 1) return input;
			var hashMap = new Dictionary<char,int>();
			var longestSubstring = string.Empty;
			var leftIndex = 0;
			var rightIndex = 0;
			while (leftIndex <= rightIndex && leftIndex < input.Length && rightIndex < input.Length)
			{
				if (!hashMap.ContainsKey(input[rightIndex]))
				{
					hashMap.Add(input[rightIndex],rightIndex);
					rightIndex++;
				}
				else
				{
					var substring = input.Substring(leftIndex, rightIndex - leftIndex );
					if (substring.Length > longestSubstring.Length)
					{
						longestSubstring = substring;
					}
					leftIndex = hashMap[input[rightIndex]]+1;
					rightIndex = leftIndex;
					hashMap.Clear();
				}
			}

			return longestSubstring;
		}

		public int Length(string input)
		{
			return LongestSubstring(input).Length;
		}
	}


}
