using Castle.Core.Logging;
using Kata;
using Kata.obj;
using Xunit;
using Xunit.Sdk;

namespace KataTests
{
	public class RemoveNthFromEndKataTest
	{
		public RemoveNthFromEndKataTest()
		{
			_kata = new RemoveNthFromEndKata();
		}

		private readonly RemoveNthFromEndKata _kata;

		[Fact]
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
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void OneItemTtest()
		{
			var inputHead = new ListNode(1);
			var n = 1;

			ListNode expected = null;
			var actual = _kata.RemoveNthFromEnd(inputHead, n);
			Assert.Equal(expected, actual);
		}
	}
}