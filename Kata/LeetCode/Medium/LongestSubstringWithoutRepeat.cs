﻿using System.Collections.Generic;

namespace Kata.LeetCode.Medium
{
	/// <summary>
	/// Longest Substring Without Repeating Characters
	/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
	/// </summary>
	public class LongestSubstringWithoutRepeat
	{
		internal string LongestSubstring(string input)
		{
			var hashMap = new Dictionary<char, int>();
			var longestSubstring = string.Empty;
			var leftIndex = 0;
			var rightIndex = 0;
			while (leftIndex <= rightIndex && rightIndex < input.Length)
			{
				if (hashMap.ContainsKey(input[rightIndex]))
				{
					UpdateLongestSubstring(input, leftIndex, rightIndex, ref longestSubstring);
					leftIndex = hashMap[input[rightIndex]] + 1;
					rightIndex = leftIndex;
					hashMap.Clear();
				}
				else
				{
					hashMap.Add(input[rightIndex], rightIndex);
					rightIndex++;
				}
			}
			UpdateLongestSubstring(input, leftIndex, rightIndex, ref longestSubstring);
			return longestSubstring;
		}

		private static void UpdateLongestSubstring(string input, int leftIndex, int rightIndex, ref string longestSubstring)
		{
			var substring = input.Substring(leftIndex, rightIndex - leftIndex);
			if (substring.Length > longestSubstring.Length)
			{
				longestSubstring = substring;
			}
		}

		public int Length(string input)
		{
			return LongestSubstring(input).Length;
		}
	}
}