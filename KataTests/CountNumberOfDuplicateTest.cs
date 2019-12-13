using Kata;
using NUnit;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class CountNumberOfDuplicateTest
	{
		private CountNumberOfDuplicate _kata;
		[SetUp]
		public void Setup()
		{
			_kata = new CountNumberOfDuplicate(); ;
		}

		[Test]
		public void EmptyStringTest()
		{
			Assert.AreEqual(0, _kata.DuplicateCount(""));
		}

		[Test]
		public void NoDuplicateTest()
		{
			Assert.AreEqual(0, _kata.DuplicateCount("abcde"));
		}

		[Test]
		public void CapitalTest()
		{
			Assert.AreEqual(2, _kata.DuplicateCount("aabBcde"));
		}

		[Test]
		[TestCase("aabbcde",2)]
		[TestCase("Indivisibility",1)]
		[TestCase("Indivisibilities",2)]
		public void SimpleTest(string input, int expected)
		{
			Assert.AreEqual(expected, _kata.DuplicateCount(input));
		}

	}
}
