using Kata.CodeWars;
using NUnit.Framework;

namespace KataTests
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
		public void SingleDigit()
		{
			Assert.AreEqual("3", _kata.Sum("1", "2"));
		}

		[Test]
		public void NoCarryOver()
		{
			Assert.AreEqual("468", _kata.Sum("123", "345"));
		}

		[Test]
		public void CarryOver()
		{
			Assert.AreEqual("1998", _kata.Sum("999", "999"));
		}

		[Test]
		public void LengthPlusOne()
		{
			Assert.AreEqual("1033", _kata.Sum("511", "522"));
		}

		[Test]
		public void UnequalLength()
		{
			Assert.AreEqual("12346", _kata.Sum("1", "12345"));
		}
	}
}