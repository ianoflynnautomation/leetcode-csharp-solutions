namespace NeetCode.Solutions.NeetCode150.LinkedLists;
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// 
    /// Example 1:
    /// 
    /// Input: head = [1,2,3,4,5]
    /// Output: [5,4,3,2,1]

[Level(Level.Easy)]
public class ReverseALinkedListSolution
{
    [TimeComplexity(" O(n)")]
    [SpaceComplexity("O(1)")]
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while(current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        return prev;
    }
}