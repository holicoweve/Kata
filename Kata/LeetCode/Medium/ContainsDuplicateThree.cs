using System;

namespace Kata.LeetCode.Medium
{
	/// <summary>
	/// 220. Contains Duplicate III
	/// 
	/// Given an array of integers, find out whether there are two distinct indices i and j in the array
	/// such that the absolute difference between nums[i] and nums[j] is at most t
	/// and the absolute difference between i and j is at most k.
	///
	/// Example 1:
	/// Input: nums = [1,2,3,1], k = 3, t = 0
	/// Output: true
	///
	/// Example 2:
	/// Input: nums = [1,0,1,1], k = 1, t = 2
	/// Output: true
	///
	/// Example 3:
	/// Input: nums = [1,5,9,1,5,9], k = 2, t = 3
	/// Output: false
	///
	/// https://leetcode.com/problems/contains-duplicate-iii/
	/// </summary>
	public class ContainsDuplicateThree
	{
		public bool ContainsNearbyAlmostDuplicate(int[] nums, int k, int t)
		{
			// TODO: gives correct answer, but need to be optimized
			if (nums.Length < 2 || k < 1)
				return false;
			for (var i = 0; i < nums.Length - 1; i++)
				for (var j = i + 1; j < nums.Length; j++)
				{
					if (AbsDiff(j, i) > k)
						break;
					if (AbsDiff(nums[i], nums[j]) <= t)
						return true;
				}

			return false;
		}

		private long AbsDiff(int a, int b)
		{
			return Math.Abs(a - (long)b);
		}
	}
}