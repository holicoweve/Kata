using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

[assembly: InternalsVisibleTo("KataTests")]
namespace Kata
{
	/// <summary>
	/// Count And Say
	/// https://leetcode.com/problems/count-and-say/
	/// </summary>
	public class CountAndSaySln
	{
		public string CountAndSay(int n)
		{
			if (n <= 1)
				return "1";

			return Say(CountAndSay(n - 1));
		}

		internal string Say(string input)
		{
			var pattern = @"(\d)\1*";
			var matches = Regex.Matches(input, pattern);
			var groups = matches.Select(a => a.Value);
			var sb = new StringBuilder();

			foreach (var i in groups)
			{
				sb.Append(i.Length);
				sb.Append(i[0]);
			}
			return sb.ToString();
		}
	}
}
