
namespace LeetCode.Solutions;

/// <summary>
/// 19. Remove Nth Node From End of List
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
/// 
/// Given the head of a linked list, remove the nth node from the end of the list and return its head.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Google)]
[Level(Level.Medium)]
public class _19_RemoveNthNodeFromEndofList
{

    [Approach(Approach.TwoPassAlgorithm)]
    [TimeComplexity("O(L)")]
    [SpaceComplexity("O(1)")]
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {

        var dummy = new ListNode(0);
        dummy.next = head;

        var first = dummy;
        var second = dummy;

        // Advance first pointer so that the gap between first and second
        // is n nodes apart

        for (int i = 1; i <= n + 1; i++)
        {
            first = first.next;
        }

        // Move first to the end, maintaining the gap
        while (first != null)
        {
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;
        return dummy.next;
    }

}