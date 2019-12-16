using System;
using System.Linq;

namespace Kata.LeetCode.Easy
{
	/// <summary>
	/// Longest Common Prefix
	/// https://leetcode.com/problems/longest-common-prefix/
	/// </summary>
	public class LongestCommonPrefix
	{
		public string FindLongestCommonPrefix(string[] inputs)
		{
			if (inputs.Length == 0)
				return string.Empty;

			var lcp = inputs[0];
			foreach (var item in inputs.Skip(1))
			{
				lcp = CommonPrefix(lcp, item);
				if (lcp == string.Empty)
					return lcp;
			}

			return lcp;

		}

		internal string CommonPrefix(string input1, string input2)
		{
			var minLength = Math.Min(input1.Length, input2.Length);
			for (var i = 0; i < minLength; i++)
			{
				if (input1[i] != input2[i])
				{
					return input1.Substring(0, i);
				}
			}

			return input1.Substring(0, minLength);
		}
	}
}
