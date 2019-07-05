using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTests
{
    [TestClass]
    public class Rot13Test
    {
        private Rot13 _kata;

        [TestInitialize]
        public void Init()
        {
            _kata = new Rot13();
        }

        [TestMethod]
        public void DoubleRot13GivesInputText()
        {
            Assert.AreEqual("aBcDeFg", _kata.Encode(_kata.Encode("aBcDeFg")));
        }

        [TestMethod]
        public void UpperCaseOnly()
        {
            Assert.AreEqual("TEST", _kata.Encode("GRFG"));
        }

        [TestMethod]
        public void LowerCaseOnly()
        {
            Assert.AreEqual("test", _kata.Encode("grfg"));
        }

        [TestMethod]
        public void MixCases()
        {
            Assert.AreEqual("TESTtest",_kata.Encode("GRFGgrfg"));
        }

        [TestMethod]
        public void NumbersShouldBeUnaffected()
        {
            Assert.AreEqual("123", _kata.Encode("123"));
        }

        [TestMethod]
        public void SpaceShouldBeUnaffected()
        {
            Assert.AreEqual(" ", _kata.Encode(" "));
        }
    }
}
