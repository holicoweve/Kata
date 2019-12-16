using System.Linq;

namespace Kata.CodeWars
{
	/// <summary>
	/// Counting Duplicates
	/// 
	/// https://www.codewars.com/kata/counting-duplicates
	/// </summary>
	public class CountNumberOfDuplicate
	{
		public int DuplicateCount(string input)
		{
			return input.ToLower().GroupBy(c => c).Count(g => g.Count() > 1);
		}
	}
}