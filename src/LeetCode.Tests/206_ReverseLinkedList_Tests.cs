
namespace LeetCode.Tests;
public class _206_ReverseLinkedList_Tests
{
    [Test]
    public void Case1()
    {
        var head = NodeGenerator.ListNode(new int[] { 1, 2, 3, 4, 5 });

        var solution = new _206_ReverseLinkedList();
        var result = solution.ReverseList(head);

        var expectedResult = NodeGenerator.ListNode(new int[] { 5, 4, 3, 2, 1 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var head = NodeGenerator.ListNode(new int[] { 1, 2 });

        var solution = new _206_ReverseLinkedList();
        var result = solution.ReverseList(head);

        var expectedResult = NodeGenerator.ListNode(new int[] { 2, 1 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var head = NodeGenerator.ListNode(new int[] { });

        var solution = new _206_ReverseLinkedList();
        var result = solution.ReverseList(head);

        var expectedResult = NodeGenerator.ListNode(new int[] { });

        result.Should().BeEquivalentTo(expectedResult);
    }
    
}
