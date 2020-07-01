using Kata.CodeWars;
using NUnit.Framework;

namespace KataTests.CodeWars
{
	[TestFixture]
	public class SumStringsAsNumbersTest
	{
		private SumStringsAsNumbers _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new SumStringsAsNumbers();
		}

		[Test]
		[TestCase("1", "2", ExpectedResult = "3", TestName = "Single digit")]
		[TestCase("123", "345", ExpectedResult = "468", TestName = "No carry over")]
		[TestCase("999", "999", ExpectedResult = "1998", TestName = "Carry over")]
		[TestCase("511", "522", ExpectedResult = "1033", TestName = "Length plus 1")]
		[TestCase("1", "12345", ExpectedResult = "12346", TestName = "Unequal length")]
		public string TestCases(string inputA, string inputB)
		{
			return _kata.Sum(inputA, inputB);
		}
	}
}