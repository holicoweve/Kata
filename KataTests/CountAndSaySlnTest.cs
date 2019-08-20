using Kata;
using Xunit;

namespace KataTests
{

	public class CountAndSaySlnTest
	{
		private CountAndSaySln _kata;


		public CountAndSaySlnTest()
		{
			_kata = new CountAndSaySln();
		}

		[Theory]
		[InlineData(1, "1")]
		[InlineData(2, "11")]
		[InlineData(3, "21")]
		[InlineData(4, "1211")]
		[InlineData(5, "111221")]
		public void CountAndSayTest(int n, string expected)
		{
			var actual = _kata.CountAndSay(n);
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void SayTest()
		{
			var input = "11";
			var expected = "21";

			var actual = _kata.Say(input);
			Assert.Equal(expected, actual);
		}
	}
}