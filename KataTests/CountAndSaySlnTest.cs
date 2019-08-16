using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
	[TestClass]
	public class CountAndSaySlnTest
	{
		private CountAndSaySln _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new CountAndSaySln();
		}

		[DataTestMethod]
		[DataRow(1, "1")]
		[DataRow(2, "11")]
		[DataRow(3, "21")]
		[DataRow(4, "1211")]
		[DataRow(5, "111221")]
		public void CountAndSayTest(int n, string expected)
		{
			var actual = _kata.CountAndSay(n);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod]
		public void SayTest()
		{
			var input = "11";
			var expected = "21";

			var actual = _kata.Say(input);
			Assert.AreEqual(expected, actual);
		}
	}
}