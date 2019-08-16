using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
	[TestClass]
	public class CountAndSaySlnTest
	{
		private CountAndSay_Sln _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new CountAndSay_Sln();
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
		
	}
}