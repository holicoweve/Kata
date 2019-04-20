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
        [TestMethod]
        public void SampleTest()
        {
            Assert.AreEqual("The Knife", BandNameGeneratorKata.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", BandNameGeneratorKata.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", BandNameGeneratorKata.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", BandNameGeneratorKata.BandNameGenerator("bed"));
        }
    }
}
