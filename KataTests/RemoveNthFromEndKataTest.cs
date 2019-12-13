using Castle.Core.Logging;
using Kata;
using NUnit.Framework;

namespace KataTests
{
	[TestFixture]
	public class RemoveNthFromEndKataTest
	{
		[SetUp]
		public void Setup()
		{
			_kata = new RemoveNthFromEndKata();
		}

		private RemoveNthFromEndKata _kata;

		[Test]
		public void SimpleTest()
		{
			var inputHead =
				new ListNode(1)
				{
					Next = new ListNode(2)
					{
						Next = new ListNode(3)
						{
							Next = new ListNode(4)
							{
								Next = new ListNode(5)
							}
						}
					}
				};
			var n = 2;

			var expected =
				new ListNode(1)
				{
					Next = new ListNode(2)
					{
						Next = new ListNode(3)
						{
							Next = new ListNode(5)
						}
					}
				};
			var actual = _kata.RemoveNthFromEnd(inputHead, n);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void OneItemTest()
		{
			var inputHead = new ListNode(1);
			var n = 1;

			ListNode expected = null;
			var actual = _kata.RemoveNthFromEnd(inputHead, n);
			Assert.AreEqual(expected, actual);
		}
	}
}