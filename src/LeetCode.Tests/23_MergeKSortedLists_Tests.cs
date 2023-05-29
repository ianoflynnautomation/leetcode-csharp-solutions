
namespace LeetCode.Tests;

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
public class _23_MergeKSortedLists_Tests
{
    [Test]
    public void Case1()
    {
        var lists = new ListNode[]
        {
            NodeGenerator.ListNode(new int[] { 1, 4, 5 }),
            NodeGenerator.ListNode(new int[] { 1, 3, 4 }),
            NodeGenerator.ListNode(new int[] { 2, 6 }),
        };

        var solution = new _23_MergeKSortedLists();
        var result = solution.MergeKLists(lists);

        var expectedResult = NodeGenerator.ListNode(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var lists = new ListNode[] { };

        var solution = new _23_MergeKSortedLists();
        var result = solution.MergeKLists(lists);

        var expectedResult = NodeGenerator.ListNode(new int[] { });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var lists = new ListNode[] { null };

        var solution = new _23_MergeKSortedLists();
        var result = solution.MergeKLists(lists);

        var expectedResult = NodeGenerator.ListNode(new int[] { });

        result.Should().BeEquivalentTo(expectedResult);
    }
}