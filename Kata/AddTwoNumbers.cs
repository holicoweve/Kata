using System;
using System.Collections.Generic;
using System.Text;

namespace Kata
{
	public class AddTwoNumbers
	{
		public ListNode Add(ListNode l1, ListNode l2, bool carry = false)
		{
			if (l1 == null && l2 == null)
			{
				return carry ? new ListNode(1) : null;
			}

			l1 = l1 ?? new ListNode(0);
			l2 = l2 ?? new ListNode(0);

			var newVal = l1.val + l2.val + (carry ? 1 : 0);
			var nextCarry = newVal >= 10;

			return new ListNode(newVal % 10) { next = Add(l1.next, l2.next, nextCarry) };
		}
	}

	public class ListNode
	{
		public int val;
		public ListNode next;

		public ListNode(int x)
		{
			val = x;
		}

		public override string ToString()
		{
			if (next != null)
			{
				return val + "->" + next;
			}

			return val.ToString();
		}

		public override bool Equals(object other)
		{
			if (!(other is ListNode otherListNode))
				return false;

			if (!val.Equals(otherListNode.val))
				return false;

			if (next == null && otherListNode.next == null)
				return true;

			if ((next == null) != (otherListNode.next == null))
				return false;

			return next.Equals(otherListNode.next);
		}
	}
}
