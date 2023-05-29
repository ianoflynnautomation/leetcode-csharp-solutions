
namespace LeetCode.Tests;

/// <summary>
/// 2. Add Two Numbers
/// https://leetcode.com/problems/add-two-numbers/
/// 
/// You are given two non-empty linked lists representing two non-negative integers. 
/// The digits are stored in reverse order, and each of their nodes contains a single digit. 
/// Add the two numbers and return the sum as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Microsoft)]
[Level(Level.Medium)]
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
