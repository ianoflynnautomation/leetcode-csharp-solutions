
namespace LeetCode.Solutions;

/// <summary>
/// 876. Middle of the Linked List
/// https://leetcode.com/problems/middle-of-the-linked-list/
///   
/// Given the head of a singly linked list, return the middle node of the linked list.
/// If there are two middle nodes, return the second middle node.
/// </summary>

[Companies(Company.Amazon, Company.Google, Company.Adobe)]
[Level(Level.Easy)]
public class _876_MiddleOfTheLinkedList
{

/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/

    public ListNode? MiddleNode(ListNode? head)
    {

        ListNode? fast = head;
        ListNode? slow = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}

