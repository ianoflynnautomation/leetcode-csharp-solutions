
namespace LeetCode.Tests;

public class _2_AddTwoNumbers_Tests
{
    [Test]
    public void Case1()
    {
        var l1 = NodeGenerator.ListNode(new int[] { 2, 4, 3 });
        var l2 = NodeGenerator.ListNode(new int[] { 5, 6, 4 });

        var solution = new _2_AddTwoNumbers();
        var result = solution.AddTwoNumbers(l1, l2);

        var expectedResult = NodeGenerator.ListNode(new int[] { 7, 0, 8 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var l1 = NodeGenerator.ListNode(new int[] { 0 });
        var l2 = NodeGenerator.ListNode(new int[] { 0 });

        var solution = new _2_AddTwoNumbers();
        var result = solution.AddTwoNumbers(l1, l2);

        var expectedResult = NodeGenerator.ListNode(new int[] { 0 });

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var l1 = NodeGenerator.ListNode(new int[] { 9, 9, 9, 9, 9, 9, 9 });
        var l2 = NodeGenerator.ListNode(new int[] { 9, 9, 9, 9 });

        var solution = new _2_AddTwoNumbers();
        var result = solution.AddTwoNumbers(l1, l2);

        var expectedResult = NodeGenerator.ListNode(new int[] { 8, 9, 9, 9, 0, 0, 0, 1 });

        result.Should().BeEquivalentTo(expectedResult);
    }

}
