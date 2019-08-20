using Kata;
using Xunit;

namespace KataTests
{
	public class DeadAntsTest
	{
		private DeadAnts _deadAnts;

		public DeadAntsTest()
		{
			_deadAnts = new DeadAnts(); ;
		}

		[Fact]
		public void BasicTest()
		{
			Assert.Equal(2, _deadAnts.DeadAntsCount("ant anantt aantnt"));

		}

		[Fact]
		public void OtherCharacterTest()
		{
			Assert.Equal(1, _deadAnts.DeadAntsCount("ant ant .... a nt"));
		}

		[Fact]
		public void NullInputTest()
		{
			Assert.Equal(0, _deadAnts.DeadAntsCount(null));
		}

		[Fact]
		public void AllAliveTest()
		{
			Assert.Equal(0, _deadAnts.DeadAntsCount("ant ant ant ant"));
		}
	}
}
