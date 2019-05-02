using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class BandNameGeneratorTest
    {
        private BandNameGeneratorKata _kata;

        [TestInitialize]
        public void init()
        {
            _kata = new BandNameGeneratorKata();
        }

        [TestMethod]
        public void TheKnifeTest()
        {
            Assert.AreEqual("The Knife", _kata.BandNameGenerator("knife"));
        }

        [TestMethod]
        public void TheBedTest()
        {
            Assert.AreEqual("The Bed", _kata.BandNameGenerator("bed"));
        }

        [TestMethod]
        public void TartartTest()
        {
            Assert.AreEqual("Tartart", _kata.BandNameGenerator("tart"));
        }

        [TestMethod]
        public void SandlesandlestTest()
        {
            Assert.AreEqual("Sandlesandles", _kata.BandNameGenerator("sandles"));
        }
    }
}
