using Kata.CodeWars;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class BandNameGeneratorTest
    {
        private BandNameGeneratorKata _kata;

        [SetUp]
        public void Setup()
        {
            _kata = new BandNameGeneratorKata();
        }

        [Test]
        public void TheKnifeTest()
        {
            Assert.AreEqual("The Knife", _kata.BandNameGenerator("knife"));
        }

        [Test]
        public void TheBedTest()
        {
            Assert.AreEqual("The Bed", _kata.BandNameGenerator("bed"));
        }

        [Test]
        public void TartartTest()
        {
            Assert.AreEqual("Tartart", _kata.BandNameGenerator("tart"));
        }

        [Test]
        public void SandlesandlestTest()
        {
            Assert.AreEqual("Sandlesandles", _kata.BandNameGenerator("sandles"));
        }
    }
}
