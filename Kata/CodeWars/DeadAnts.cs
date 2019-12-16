using System.Linq;

namespace Kata.CodeWars
{
	public class DeadAnts
	{
		/// <summary>
		///     Kata - Dead Ants
		///     An orderly trail of ants is marching across the park picnic area.
		///     It looks something like this:
		///     ..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..
		///     But suddenly there is a rumour that a dropped chicken sandwich has been spotted on the ground ahead.
		///     The ants surge forward! Oh No, it's an ant stampede!!
		///     Some of the slower ants are trampled, and their poor little ant bodies are broken up into scattered bits.
		///     The resulting carnage looks like this:
		///     ...ant...ant..nat.ant.t..ant...ant..ant..ant.anant..t
		///     Can you find how many ants have died?
		/// 
		///     https://www.codewars.com/kata/dead-ants/csharp
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public int DeadAntsCount(string input)
		{
			if (string.IsNullOrEmpty(input))
				return 0;
			input = input.ToLower();

			var bodyCounts = input.Replace("ant", "").GroupBy(c => c).Where(c => "ant".Contains(c.Key));
			return !bodyCounts.Any() ? 0 : bodyCounts.Select(c => c.Count()).Max();
		}
	}
}