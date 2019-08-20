using Kata;
using Xunit;

namespace KataTests
{
	public class SumStringsAsNumbersTest
    {
        private SumStringsAsNumbers _kata;

        public SumStringsAsNumbersTest()
        {
            _kata = new SumStringsAsNumbers();
        }

        [Fact]
        public void SingleDigit()
        {
            Assert.Equal("3",_kata.Sum("1","2"));
        }

        [Fact]
        public void NoCarryOver()
        {
            Assert.Equal("468", _kata.Sum("123", "345"));
        }

        [Fact]
        public void CarryOver()
        {
            Assert.Equal("1998",_kata.Sum("999","999"));
        }

        [Fact]
        public void LengthPlusOne()
        {
            Assert.Equal("1033",_kata.Sum("511","522"));
        }

        [Fact]
        public void UnequalLength()
        {
            Assert.Equal("12346",_kata.Sum("1","12345"));
        }

    }
}
