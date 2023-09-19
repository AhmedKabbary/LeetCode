namespace Problems.Solutions;

public class Problem2
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode? head = null;
        ListNode? tail = null;

        int carry = 0;

        ListNode? node1 = l1;
        ListNode? node2 = l2;

        while (node1 is not null || node2 is not null)
        {
            int sum = (node1?.val ?? 0) + (node2?.val ?? 0) + carry;
            carry = 0;

            int value = sum;
            if (sum > 9)
            {
                carry = 1;
                value = sum % 10;
            }

            var newTail = new ListNode(value);

            if (head is null)
                head = newTail;
            else
                tail!.next = newTail;

            tail = newTail;

            node1 = node1?.next;
            node2 = node2?.next;
        }

        if (carry == 1) tail!.next = new ListNode(1);

        return head!;
    }

    public class ListNodeComparer : IEqualityComparer<ListNode>
    {
        public bool Equals(ListNode? x, ListNode? y)
        {
            if (ReferenceEquals(x, y))
                return true;

            if (x is null || y is null)
                return false;

            return x.val == y.val && Equals(x.next, y.next);
        }

        public int GetHashCode(ListNode obj) => HashCode.Combine(obj.val, obj.next);
    }
}