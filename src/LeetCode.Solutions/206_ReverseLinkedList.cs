
namespace LeetCode.Solutions
{
    public class _206_ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode current = head;
            ListNode reversed = default;

            while (current != null)
            {
                ListNode next = current.next;
                current.next = reversed;
                reversed = current;

                current = next;
            }

            return reversed;

        }
    }
}