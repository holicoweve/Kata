using System;
using System.Collections.Generic;
using System.Text;
using Kata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataTests
{
    [TestClass]
    public class SumStringsAsNumbersTest
    {
        private SumStringsAsNumbers _kata;

        [TestInitialize]
        public void Init()
        {
            _kata = new SumStringsAsNumbers();
        }

        [TestMethod]
        public void SingleDigit()
        {
            Assert.AreEqual("3",_kata.Sum("1","2"));
        }

        [TestMethod]
        public void NoCarryOver()
        {
            Assert.AreEqual("468", _kata.Sum("123", "345"));
        }

        [TestMethod]
        public void CarryOver()
        {
            Assert.AreEqual("1998",_kata.Sum("999","999"));
        }

        [TestMethod]
        public void LengthPlusOne()
        {
            Assert.AreEqual("1033",_kata.Sum("511","522"));
        }

        [TestMethod]
        public void UnequalLength()
        {
            Assert.AreEqual("12346",_kata.Sum("1","12345"));
        }

    }
}
