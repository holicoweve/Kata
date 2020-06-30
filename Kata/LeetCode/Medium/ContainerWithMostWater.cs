using System;

namespace Kata.LeetCode.Medium
{
	/// <summary>
	/// 11. Container With Most Water
	///
	/// https://leetcode.com/problems/container-with-most-water/
	/// </summary>
	public class ContainerWithMostWater
	{
		public int MaxArea(int[] height)
		{
			var maxArea = 0;
			var leftIndex = 0;
			var rightIndex = height.Length - 1;
			while (leftIndex < rightIndex)
			{
				var tempArea = CalculateArea(height, leftIndex, rightIndex);
				maxArea = Math.Max(maxArea, tempArea);

				if (height[leftIndex] < height[rightIndex])
				{
					leftIndex++;
				}
				else
				{
					rightIndex--;
				}
			}

			return maxArea;
		}

		private int CalculateArea(int[] height, int leftIndex, int rightIndex)
		{
			var width = rightIndex - leftIndex;
			var lowerBound = Math.Min(height[leftIndex], height[rightIndex]);
			return width * lowerBound;
		}
	}
}