namespace Kata.LeetCode.DataStructure
{
	public class ListNode
	{
		public int Val;
		public ListNode Next;

		public ListNode(int x)
		{
			Val = x;
		}

		public override bool Equals(object  obj)
		{
			var otherNode = obj as ListNode;
			if (Val != otherNode.Val)
			{
				return false;
			}

			if (Next == null)
			{
				return otherNode.Next == null;
			}

			if (otherNode.Next == null)
			{
				return Next == null;
			}

			return Next.Equals(otherNode.Next);
		}
	}
}