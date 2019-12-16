using System.Collections.Generic;
using System.Linq;

namespace Kata.LeetCode.Medium
{
	/// <summary>
	///     15. 3Sum
	///     Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0?
	///     Find all unique triplets in the array which gives the sum of zero.
	///     Note:
	///     The solution set must not contain duplicate triplets.
	///     Example:
	///     Given array nums = [-1, 0, 1, 2, -1, -4],
	///     A solution set is:
	///     [
	///     [-1, 0, 1],
	///     [-1, -1, 2]
	///     ]
	/// </summary>
	public class ThreeSumKata
	{
		public IList<IList<int>> ThreeSum(int[] inputs)
		{
			// TODO: gives correct answer, but need to be optimized
			var solutions = new List<IList<int>>();
			var target = 0;
			if (inputs.Length < 3)
				return new List<IList<int>>();
			for (var i = 0; i < inputs.Length - 2; i++)
			{
				var iValue = inputs[i];
				var iTarget = target - iValue;
				for (var j = i + 1; j < inputs.Length - 1; j++)
				{
					var jValue = inputs[j];
					var jTarget = iTarget - jValue;
					for (var k = j + 1; k < inputs.Length; k++)
					{
						var kValue = inputs[k];
						if (kValue == jTarget)
						{
							var solution = new List<int> { iValue, jValue, kValue };
							solution.Sort();
							if (!solutions.Exists(x => x.SequenceEqual(solution)))
								solutions.Add(solution);
						}
					}
				}
			}

			return solutions;
		}
	}
}