
namespace LeetCode.Solutions;

/// <summary>
/// 21. Merge Two Sorted Lists
/// https://leetcode.com/problems/merge-two-sorted-lists/
/// 
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists in a one sorted list. 
/// The list should be made by splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Expedia)]
[Level(Level.Easy)]
public class _21_MergeTwoSortedLists
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
     
    [Approach(Approach.Iteration)]
    [TimeComplexity("O(n+m)")]
    [SpaceComplexity("O(1)")]
    public ListNode? MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode dummyHead = new ListNode(-1);
        ListNode current = dummyHead;

        while (l1 != null && l2 != null)
        {
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

            current = current.next;
        }

        if (l1 != null) current.next = l1;
        if (l2 != null) current.next = l2;

        return dummyHead.next;
    }
}