using System.Collections.Generic;

namespace Kata
{
	/// <summary>
	///     Remove Nth Node From End of List
	///     https://leetcode.com/problems/remove-nth-node-from-end-of-list/
	/// </summary>
	public class RemoveNthFromEndKata
	{
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			var nodeList = new List<ListNode>();
			var currNode = head;
			nodeList.Add(currNode);
			while (currNode.Next != null)
			{
				currNode = currNode.Next;
				nodeList.Add(currNode);
			}

			var skipNode = nodeList.Count - n;
			ListNode prevNode = null;
			head = prevNode;
			for (var i = nodeList.Count - 1; i >= 0; i--)
			{
				if (i == skipNode) i--;
				if (i < 0)
				{
					break;
				}
				currNode = nodeList[i];
				currNode.Next = prevNode;

				prevNode = currNode;
				head = prevNode;
			}

			return head;
		}
	}
}