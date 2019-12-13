using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class Rot13Test
	{
		private Rot13 _kata;

		[SetUp]
		public void Setup()
		{
			_kata = new Rot13();
		}

		[Test]
		public void DoubleRot13GivesInputText()
		{
			Assert.AreEqual("aBcDeFg", _kata.Encode(_kata.Encode("aBcDeFg")));
		}

		[Test]
		public void UpperCaseOnly()
		{
			Assert.AreEqual("TEST", _kata.Encode("GRFG"));
		}

		[Test]
		public void LowerCaseOnly()
		{
			Assert.AreEqual("test", _kata.Encode("grfg"));
		}

		[Test]
		public void MixCases()
		{
			Assert.AreEqual("TESTtest", _kata.Encode("GRFGgrfg"));
		}

		[Test]
		public void NumbersShouldBeUnaffected()
		{
			Assert.AreEqual("123", _kata.Encode("123"));
		}

		[Test]
		public void SpaceShouldBeUnaffected()
		{
			Assert.AreEqual(" ", _kata.Encode(" "));
		}
	}
}
