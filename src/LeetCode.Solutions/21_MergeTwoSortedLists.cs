
namespace LeetCode.Solutions
{
    public class _21_MergeTwoSortedLists
    {
        public ListNode? MergeTwoLists(ListNode? l1, ListNode? l2)
        {
            // Edge case: If either list is empty, return the other list
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            // Create a new dummy head
            ListNode? dummyHead = new ListNode(-1);

            // Create a pointer to the dummy head
            ListNode? current = dummyHead;

            // Loop until one of the lists is empty
            while (l1 != null && l2 != null)
            {
                // Compare the values of the two lists and add the smaller value to the result list
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                // Move the pointer to the next node
                current = current.next;
            }

            // Add the remaining elements of the non-empty list to the result list
            if (l1 != null) current.next = l1;
            if (l2 != null) current.next = l2;

            // Return the result list, excluding the dummy head
            return dummyHead.next;
        }
    }

    //Definition for singly-linked list.
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
}