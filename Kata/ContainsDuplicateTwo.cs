using System.Linq;

namespace Kata
{
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