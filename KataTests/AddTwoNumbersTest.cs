using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace KataTests
{
	[TestClass]
	public class AddTwoNumbersTest
	{
		private AddTwoNumbers _kata;

		[TestInitialize]
		public void Init()
		{
			_kata = new AddTwoNumbers();
		}

		[TestMethod]
		public void Test_TwoZero()
		{
			var l1 = new ListNode(0);
			var l2 = new ListNode(0);

			var expected = new ListNode(0);
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_TwoSingleDigit_NoCarry()
		{
			var l1 = new ListNode(1);
			var l2 = new ListNode(2);

			var expected = new ListNode(3);
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_TwoSingleDigit_Carry()
		{
			var l1 = new ListNode(5);
			var l2 = new ListNode(7);

			var expected = new ListNode(2) { next = new ListNode(1) };
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_TwoDoubleDigit_NoCarry()
		{
			var l1 = new ListNode(1) { next = new ListNode(3) };
			var l2 = new ListNode(2) { next = new ListNode(6) };

			var expected = new ListNode(3) { next = new ListNode(9) };
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_TwoDoubleDigit_Carry()
		{
			var l1 = new ListNode(6) { next = new ListNode(3) };
			var l2 = new ListNode(7) { next = new ListNode(6) };

			var expected = new ListNode(3) { next = new ListNode(0) { next = new ListNode(1) } };
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_UnequalLength_NoCarry()
		{
			var l1 = new ListNode(6) { next = new ListNode(3) };
			var l2 = new ListNode(1);

			var expected = new ListNode(7) { next = new ListNode(3) };
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}

		[TestMethod]
		public void Test_UnequalLength_Carry()
		{
			var l1 = new ListNode(9) { next = new ListNode(9) };
			var l2 = new ListNode(1);

			var expected = new ListNode(0) { next = new ListNode(0) { next = new ListNode(1) } };
			var actual = _kata.Add(l1, l2);

			Assert.AreEqual<ListNode>(expected, actual);
		}
	}
}
