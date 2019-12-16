using Kata.CodeWars;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class DeadAntsTest
	{
		private DeadAnts _deadAnts;

		[SetUp]
		public void Setup()
		{
			_deadAnts = new DeadAnts(); ;
		}

		[Test]
		public void BasicTest()
		{
			Assert.AreEqual(2, _deadAnts.DeadAntsCount("ant anantt aantnt"));

		}

		[Test]
		public void OtherCharacterTest()
		{
			Assert.AreEqual(1, _deadAnts.DeadAntsCount("ant ant .... a nt"));
		}

		[Test]
		public void NullInputTest()
		{
			Assert.AreEqual(0, _deadAnts.DeadAntsCount(null));
		}

		[Test]
		public void AllAliveTest()
		{
			Assert.AreEqual(0, _deadAnts.DeadAntsCount("ant ant ant ant"));
		}
	}
}
