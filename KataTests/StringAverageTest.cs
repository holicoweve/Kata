using Kata;
using Kata.obj;
using Xunit;

namespace KataTests
{
	public class StringAverageTest
	{
		private StringAverage _kata;

		public StringAverageTest()
		{
			_kata = new StringAverage();
		}

		[Theory]
		[InlineData("one", "one")]
		[InlineData("two", "two")]
		public void SingleInputTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}

		[Theory]
		[InlineData("zero nine five two", "four")]
		[InlineData("four six two three", "three")]
		[InlineData("one two three four five", "three")]
		public void ComplexTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}

		[Theory]
		[InlineData("five four", "four")]
		public void RoundDownTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}

		[Theory]
		[InlineData("one one eight one", "two")]
		public void SomeRepeatedElementTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}

		[Theory]
		[InlineData("zero zero zero zero zero", "zero")]
		public void AllZeroInputTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}

		[Theory]
		[InlineData(" ", "n/a")]
		public void EmptyInputTest(string input, string expected)
		{
			Assert.Equal(expected, _kata.AverageString(input));
		}
	}

	public class ExtensionsTest
	{
		[Theory]
		[InlineData(0, "zero")]
		[InlineData(1, "one")]
		[InlineData(2, "two")]
		[InlineData(9, "nine")]
		public void IntToStringTest(int input, string expected)
		{
			Assert.Equal(expected, input.IntToText());
		}

		[Theory]
		[InlineData("zero", 0)]
		[InlineData("one", 1)]
		[InlineData("two", 2)]
		[InlineData("nine", 9)]
		public void StringToIntTest(string input, int expected)
		{
			Assert.Equal(expected, input.TextToInt());
		}
	}
}
