
namespace LeetCode.Tests;
public class _19_RemoveNthNodeFromEndofList_Tests
{
    [Test]
    public void Case1()
    {
        var head = NodeGenerator.ListNode(new int[] { 1, 2, 3, 4, 5 });
        var n = 2;

        var solution = new _19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, n);

        var expectedResult = NodeGenerator.ListNode(new int[] { 1, 2, 3, 5 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var head = NodeGenerator.ListNode(new int[] { 1 });
        var n = 1;

        var solution = new _19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, n);

        var expectedResult = NodeGenerator.ListNode(new int[] { });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var head = NodeGenerator.ListNode(new int[] { 1, 2 });
        var n = 1;

        var solution = new _19_RemoveNthNodeFromEndofList();
        var result = solution.RemoveNthFromEnd(head, n);

        var expectedResult = NodeGenerator.ListNode(new int[] { 1 });

        result.Should().BeEquivalentTo(expectedResult);
    }

}