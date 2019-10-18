

namespace Kata
{
    public class AddTwoNumbers
    {
        public ListNode Add(ListNode l1, ListNode l2, bool carry = false)
        {
            if (l1 == null && l2 == null) return carry ? new ListNode(1) : null;

            l1 = l1 ?? new ListNode(0);
            l2 = l2 ?? new ListNode(0);

            var newVal = l1.Val + l2.Val + (carry ? 1 : 0);
            var nextCarry = newVal >= 10;

            return new ListNode(newVal % 10) { Next = Add(l1.Next, l2.Next, nextCarry) };
        }
    }


    public class ListNode
    {
        public int Val;
        public ListNode Next;
        public ListNode(int x) { Val = x; }

        public override bool Equals(object obj)
        {
            var otherNode = obj as ListNode;
            if(Val != otherNode.Val)
            {
                return false;
            }
            if(Next == null)
            {
                return otherNode.Next==null;
            }
            if(otherNode.Next==null)
            {
                return Next==null;
            }

            return Next.Equals(otherNode.Next);
        }
    }

}