
namespace LeetCode.Solutions;

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

public class _23_MergeKSortedLists
{
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
