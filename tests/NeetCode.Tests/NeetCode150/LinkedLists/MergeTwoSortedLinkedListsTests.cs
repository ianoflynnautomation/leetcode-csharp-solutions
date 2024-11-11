using Core.Helpers;
using NeetCode.Solutions.NeetCode150.LinkedLists;

namespace NeetCode.Tests.NeetCode150.LinkedLists;

public class MergeTwoSortedLinkedListsTests
{
        [Test]
    public void Case1()
    {
        var list1 = NodeGenerator.ListNode([1, 2, 4]);
        var list2 = NodeGenerator.ListNode([ 1, 3, 5 ]);

        var solution = new MergeTwoSortedLinkedListsSolution();
        var result = solution.MergeTwoLists(list1, list2);

        var expectedResult = NodeGenerator.ListNode([1, 1, 2, 3, 4, 5]);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var list1 = NodeGenerator.ListNode([]);
        var list2 = NodeGenerator.ListNode([]);

        var solution = new MergeTwoSortedLinkedListsSolution();
        var result = solution.MergeTwoLists(list1, list2);

        var expectedResult = NodeGenerator.ListNode([]);

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var list1 = NodeGenerator.ListNode([]);
        var list2 = NodeGenerator.ListNode([0]);

        var solution = new MergeTwoSortedLinkedListsSolution();
        var result = solution.MergeTwoLists(list1, list2);

        var expectedResult = NodeGenerator.ListNode([0]);

        result.Should().BeEquivalentTo(expectedResult);
    }
    
}
