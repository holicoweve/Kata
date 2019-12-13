using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class CountAndSaySlnTest
	{
		private CountAndSaySln _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new CountAndSaySln();
		}

		[Theory]
		[TestCase(1, "1")]
		[TestCase(2, "11")]
		[TestCase(3, "21")]
		[TestCase(4, "1211")]
		[TestCase(5, "111221")]
		public void CountAndSayTest(int n, string expected)
		{
			var actual = _kata.CountAndSay(n);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void SayTest()
		{
			var input = "11";
			var expected = "21";

			var actual = _kata.Say(input);
			Assert.AreEqual(expected, actual);
		}
	}
}