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

			var newVal = l1.Val + l2.Val + (carry ? 1 : 0);
			var nextCarry = newVal >= 10;

			return new ListNode(newVal % 10) { Next = Add(l1.Next, l2.Next, nextCarry) };
		}
	}

	public class ListNode
	{
		public int Val { get; }
		public ListNode Next { get; set; }

		public ListNode(int x)
		{
			Val = x;
		}

		public override string ToString()
		{
			if (Next != null)
			{
				return Val + "->" + Next;
			}

			return Val.ToString();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ListNode otherListNode))
				return false;

			if (!Val.Equals(otherListNode.Val))
				return false;

			if (Next == null && otherListNode.Next == null)
				return true;

			if ((Next == null) != (otherListNode.Next == null))
				return false;

			return Next.Equals(otherListNode.Next);
		}
	}
}
