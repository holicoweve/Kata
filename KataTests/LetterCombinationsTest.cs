using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Kata;
using Xunit;

namespace KataTests
{
	public class LetterCombinationsTest
	{
		private LetterCombinationsKata _kata;

		public LetterCombinationsTest()
		{
			_kata = new LetterCombinationsKata();
		}

		[Fact]
		public void InvalidInput()
		{
			var input = "a";
			var expected = new string[] { };
			var actual = _kata.LetterCombinations(input);

			CollectionEqual(expected, actual);
		}

		[Fact]
		public void EmptyInput()
		{
			var input = string.Empty;
			var expected = new string[] { };
			var actual = _kata.LetterCombinations(input);

			CollectionEqual(expected, actual);
		}

		[Fact]
		public void TwoDigits()
		{
			var input = "23";
			var expected = new[] { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };
			var actual = _kata.LetterCombinations(input);

			CollectionEqual(expected, actual);
		}

		private void CollectionEqual(IEnumerable<string> collection1, IEnumerable<string> collection2)
		{
			//Assert.Equal(collection1, collection2);
			var list1 = collection1.ToImmutableList();
			var list2 = collection2.ToImmutableList();
			Assert.Equal(list1.Count(), list2.Count());
			if (list1.Count == 0)
				return;
			Assert.Contains(list1, x => list2.Contains(x));
			Assert.Contains(list2, x => list1.Contains(x));
		}
	}
}
