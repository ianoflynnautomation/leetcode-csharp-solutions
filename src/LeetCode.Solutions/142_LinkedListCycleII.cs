
namespace LeetCode.Solutions;
public class _142_LinkedListCycleII
{

    /**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) {
*         val = x;
*         next = null;
*     }
* }
*/
    public ListNode? DetectCycle(ListNode? head)
    {

        ListNode? slow = head;
        ListNode? fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        }
        return null;
    }

}