using Kata;
using Xunit;

namespace KataTests
{
	public class Rot13Test
	{
		private Rot13 _kata;

		public Rot13Test()
		{
			_kata = new Rot13();
		}

		[Fact]
		public void DoubleRot13GivesInputText()
		{
			Assert.Equal("aBcDeFg", _kata.Encode(_kata.Encode("aBcDeFg")));
		}

		[Fact]
		public void UpperCaseOnly()
		{
			Assert.Equal("TEST", _kata.Encode("GRFG"));
		}

		[Fact]
		public void LowerCaseOnly()
		{
			Assert.Equal("test", _kata.Encode("grfg"));
		}

		[Fact]
		public void MixCases()
		{
			Assert.Equal("TESTtest", _kata.Encode("GRFGgrfg"));
		}

		[Fact]
		public void NumbersShouldBeUnaffected()
		{
			Assert.Equal("123", _kata.Encode("123"));
		}

		[Fact]
		public void SpaceShouldBeUnaffected()
		{
			Assert.Equal(" ", _kata.Encode(" "));
		}
	}
}
