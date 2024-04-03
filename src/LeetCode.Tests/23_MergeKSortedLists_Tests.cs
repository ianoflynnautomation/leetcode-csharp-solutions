
namespace LeetCode.Tests;

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