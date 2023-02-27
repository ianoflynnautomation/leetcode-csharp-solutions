
namespace LeetCode.Solutions
{
    public class _206_ReverseLinkedList
    {
        public ListNode? ReverseList(ListNode? head)
        {
            // Edge case: If the list is empty or has only one element, return it
            if (head == null || head.next == null) return head;

            // Create a pointer to the head
            ListNode? current = head;

            // Initialize the reversed list to null
            ListNode? reversed = null;

            // Iterate through the list
            while (current != null)
            {
                // Save the next element
                ListNode? next = current.next;

                // Add the current element to the beginning of the reversed list
                current.next = reversed;
                reversed = current;

                // Move the pointer to the next element
                current = next;
            }

            // Return the reversed list
            return reversed;

        }

    }
}