
namespace LeetCode.Solutions;

/// <summary>
/// 206. Reverse Linked List
/// https://leetcode.com/problems/reverse-linked-list/
/// 
/// Given the head of a singly linked list, reverse the list, and return the reversed list.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Bloomberg)]
[Level(Level.Easy)]
public class _206_ReverseLinkedList
{
    public ListNode ReverseList(ListNode head)
    {
        if(head is null || head.next is null) return head;

        ListNode current = head;
        ListNode reversed = default;

        while (current is not null)
        {
            ListNode next = current.next;
            current.next = reversed;
            reversed = current;

            current = next;
        }

        return reversed;

    }
}