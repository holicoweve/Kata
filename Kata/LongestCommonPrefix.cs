using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata
{
	/// <summary>
	/// Longest Common Prefix
	/// https://leetcode.com/problems/longest-common-prefix/
	/// </summary>
	public class LongestCommonPrefix
	{
		public string FindLongestCommonPrefix(string[] inputs)
		{
			var prefix = string.Empty;
			
			if (inputs.Length == 0)
				return prefix;

			var shortestItem = inputs.OrderBy(i => i.Length).First();
			var maxLength = shortestItem.Length;

			for(var i = 1;i<=maxLength;i++)
			{
				var prevPrefix = prefix;
				prefix = shortestItem.Substring(0, i);
				foreach (var item in inputs)
				{
					if (!item.StartsWith(prefix))
						return prevPrefix;
				}
			}

			return shortestItem;
		}

		private string CommonPrefix(string input1, string input2)
		{
			throw new NotImplementedException();
		}
	}
}
