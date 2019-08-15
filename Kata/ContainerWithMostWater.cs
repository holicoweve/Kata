using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;


namespace Kata
{
	/// <summary>
	/// Container With Most Water
	/// https://leetcode.com/problems/container-with-most-water/
	/// </summary>
	public class ContainerWithMostWater
	{
		public int MaxArea(int[] height)
		{
			var maxArea = 0;

			for (int leftIndex = 0; leftIndex < height.Length - 1; leftIndex++)
			{
				if (height[leftIndex] * height.Length - leftIndex - 1 < maxArea)
					continue;

				for (int rightIndex = leftIndex + 1; rightIndex < height.Length; rightIndex++)
				{
					var tempArea = CalculateArea(height, leftIndex, rightIndex);
					maxArea = Math.Max(maxArea, tempArea);
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
