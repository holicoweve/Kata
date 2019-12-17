using System.Linq;

namespace Kata.LeetCode.Medium
{
	public class SearchInRotatedSortedArray
	{
		public int Search(int[] nums, int target)
		{
			if (nums.Length == 0)
				return -1;
			if (nums.Length == 1)
			{
				return nums[0] == target ? 0 : -1;
			}

			var currentLength = nums.Length / 2;
			bool leftPriority = !(target > nums[currentLength]);
			var priorityPart = leftPriority ? nums.Take(currentLength).ToArray() : nums.Skip(currentLength).ToArray();
			var offSet = leftPriority ? 0 : currentLength;

			var priorityIndex = Search(priorityPart, target);
			if (priorityIndex >= 0)
				return offSet + priorityIndex;
			leftPriority = !leftPriority;
			priorityPart = leftPriority ? nums.Take(currentLength).ToArray() : nums.Skip(currentLength).ToArray();
			offSet = leftPriority ? 0 : currentLength;
			priorityIndex = Search(priorityPart, target);
			if (priorityIndex >= 0)
				return offSet + priorityIndex;

			return -1;
		}

		public int Search2(int[] nums, int target)
		{
			if (nums.Length == 0)
				return -1;
			if (nums.Length == 1)
			{
				return nums[0] == target ? 0 : -1;
			}

			var currentLength = nums.Length / 2;

			var leftResult = Search(nums.Take(currentLength).ToArray(), target);
			if (leftResult >= 0)
				return leftResult;
			var rightResult = Search(nums.Skip(currentLength).ToArray(), target);
			if (rightResult >= 0)
				return currentLength + rightResult;
			return -1;
		}
	}
}