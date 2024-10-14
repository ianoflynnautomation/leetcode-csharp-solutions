
namespace LeetCode.Solutions;

/// <summary>
/// 23. Merge k Sorted Lists
/// https://leetcode.com/problems/merge-k-sorted-lists/
/// 
/// You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
/// Merge all the linked-lists into one sorted linked-list and return it.
/// 
/// Constraints:
/// k == lists.length
/// 0 <= k <= 104
/// 0 <= lists[i].length <= 500
/// -104 <= lists[i][j] <= 104
/// lists[i] is sorted in ascending order.
/// The sum of lists[i].length will not exceed 104.
/// </summary>

[Companies(Company.Google, Company.Amazon, Company.Tesla)]
[Level(Level.Hard)]
public class _23_MergeKSortedLists
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

    [Approach(Approach.PriorityQueue)]
    [TimeComplexity("O(Nlogk)")]
    [SpaceComplexity("O(n)")]
    public ListNode MergeKLists(ListNode[] lists)
    {

        var heap = new PriorityQueue<ListNode, int>();

        foreach (var list in lists)
            if (list != null)
                heap.Enqueue(list, list.val);

        var fakeHead = new ListNode();
        var tail = fakeHead;

        while (heap.TryDequeue(out var list, out _))
        {
            tail.next = list;
            tail = list;

            if (list.next != null)
                heap.Enqueue(list.next, list.next.val);
        }

        return fakeHead.next;
    }

}
