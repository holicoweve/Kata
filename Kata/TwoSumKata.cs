using System.Collections.Generic;

namespace Kata
{
	/// <summary>
	///     Kata - Two Sums
	///     Given an array of integers, return indices of the two numbers such that they add up to a specific target.
	///     You may assume that each input would have exactly one solution, and you may not use the same element twice.
	///     Example:
	///     Given nums = [2, 7, 11, 15], target = 9,
	///     Because nums[0] + nums[1] = 2 + 7 = 9,
	///     return [0, 1].
	///     https://leetcode.com/problems/two-sum/
	/// </summary>
	public class TwoSumKata
	{
		public int[] TwoSum(int[] inputs, int target)
		{
			var reverseDictionary = new Dictionary<int, int>();

			for (var currentIndex = 0; currentIndex < inputs.Length; currentIndex++)
			{
				var currentValue = inputs[currentIndex];
				var diff = target - currentValue;
				if (reverseDictionary.ContainsKey(currentValue))
				{
					// pair found
					var firstIndex = reverseDictionary[currentValue];
					return new[] { firstIndex, currentIndex };
				}

				if (reverseDictionary.ContainsKey(diff))
				{
					// same element , will ignore
				}
				else
				{
					// pair not found, put current diff into dictionary as key, and current index as value
					reverseDictionary.Add(diff, currentIndex);
				}
			}

			return new int[] { };
		}
	}
}