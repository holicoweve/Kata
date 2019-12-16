using System.Linq;

namespace Kata.LeetCode.Easy
{
	/// <summary>
	/// 219. Contains Duplicate II
	///
	/// Given an array of integers and an integer k, find out whether there are two distinct indices i and j in the array
	/// such that nums[i] = nums[j] and the absolute difference between i and j is at most k.
	/// 
	/// https://leetcode.com/problems/contains-duplicate-ii/
	/// </summary>
	public class ContainsDuplicateTwo
	{
		public bool ContainsNearbyDuplicate(int[] inputs, int k)
		{
			var groups = inputs
				.Select((value, index) => new { value, index })
				.GroupBy(item => item.value, item => item.index)
				.Where(group => group.Count() >= 2);

			foreach (var group in groups)
			{
				var groupArray = group.ToArray();
				for (var i = 0; i < groupArray.Count() - 1; i++)
					if (groupArray.ElementAt(i + 1) - groupArray.ElementAt(i) <= k)
						return true;
			}

			return false;
		}
	}
}