using Kata;
using Xunit;

namespace KataTests
{

    public class BandNameGeneratorTest
    {
        private BandNameGeneratorKata _kata;

        public BandNameGeneratorTest()
        {
            _kata = new BandNameGeneratorKata();
        }

        [Fact]
        public void TheKnifeTest()
        {
            Assert.Equal("The Knife", _kata.BandNameGenerator("knife"));
        }

        [Fact]
        public void TheBedTest()
        {
            Assert.Equal("The Bed", _kata.BandNameGenerator("bed"));
        }

        [Fact]
        public void TartartTest()
        {
            Assert.Equal("Tartart", _kata.BandNameGenerator("tart"));
        }

        [Fact]
        public void SandlesandlestTest()
        {
            Assert.Equal("Sandlesandles", _kata.BandNameGenerator("sandles"));
        }
    }
}
