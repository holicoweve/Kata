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
            Assert.AreEqual("The Knife", BandNameGenerators.BandNameGenerator("knife"));
            Assert.AreEqual("Tartart", BandNameGenerators.BandNameGenerator("tart"));
            Assert.AreEqual("Sandlesandles", BandNameGenerators.BandNameGenerator("sandles"));
            Assert.AreEqual("The Bed", BandNameGenerators.BandNameGenerator("bed"));
        }
    }
}
