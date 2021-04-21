using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;

namespace Kata.LeetCode.Medium
{
	public class BestSightseeingPair
	{
		public int MaxScoreSightseeingPair(int[] input)
		{
			var maxScore = 0;
			var i = 0;
			var j = 1;
			while (true)
			{
				var score = Score(input, i, j);
				if (score > maxScore)
				{
					Console.WriteLine($"i = {i}, j = {j}, A[i] + A[j] + i - j = {input[i]} + {input[j]} + {i} - {j} = {maxScore}");
					maxScore = score;
				}

				j++;
				if (j > input.Length-1)
				{
					i++;
					j = i + 1;
				}

				if (i > input.Length-2)
				{
					return maxScore;
				}
			}
			//for (var i = 0; i < input.Length-1; i++)
			//{
			//	for (var j = i + 1; j < input.Length; j++)
			//	{
			//		var score = Score(input, i, j);
			//		if (score > maxScore)
			//		{
			//			maxScore = score;
			//		}
			//	}
			//}

			//return maxScore;
		}

		private int Score(int[] input, int indexI, int indexJ)
		{
			return input[indexI] + input[indexJ] + indexI - indexJ;
		}
	}
}
