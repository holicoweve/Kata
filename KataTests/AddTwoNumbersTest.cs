using Kata;
using Kata.obj;
using Xunit;

namespace KataTests
{
	public class AddTwoNumbersTest
	{
		private AddTwoNumbers _kata;

		public AddTwoNumbersTest()
		{
			_kata = new AddTwoNumbers();
		}

		[Fact]
		public void Test_TwoZero()
		{
			var l1 = new ListNode(0);
			var l2 = new ListNode(0);

			var expected = new ListNode(0);
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_TwoSingleDigit_NoCarry()
		{
			var l1 = new ListNode(1);
			var l2 = new ListNode(2);

			var expected = new ListNode(3);
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_TwoSingleDigit_Carry()
		{
			var l1 = new ListNode(5);
			var l2 = new ListNode(7);

			var expected = new ListNode(2) { Next = new ListNode(1) };
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_TwoDoubleDigit_NoCarry()
		{
			var l1 = new ListNode(1) { Next = new ListNode(3) };
			var l2 = new ListNode(2) { Next = new ListNode(6) };

			var expected = new ListNode(3) { Next = new ListNode(9) };
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_TwoDoubleDigit_Carry()
		{
			var l1 = new ListNode(6) { Next = new ListNode(3) };
			var l2 = new ListNode(7) { Next = new ListNode(6) };

			var expected = new ListNode(3) { Next = new ListNode(0) { Next = new ListNode(1) } };
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_UnequalLength_NoCarry()
		{
			var l1 = new ListNode(6) { Next = new ListNode(3) };
			var l2 = new ListNode(1);

			var expected = new ListNode(7) { Next = new ListNode(3) };
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}

		[Fact]
		public void Test_UnequalLength_Carry()
		{
			var l1 = new ListNode(9) { Next = new ListNode(9) };
			var l2 = new ListNode(1);

			var expected = new ListNode(0) { Next = new ListNode(0) { Next = new ListNode(1) } };
			var actual = _kata.Add(l1, l2);

			Assert.Equal<ListNode>(expected, actual);
		}
	}
}
