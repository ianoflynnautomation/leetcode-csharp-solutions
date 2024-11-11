using Core.Helpers;
using NeetCode.Solutions.NeetCode150.LinkedLists;

namespace NeetCode.Tests.NeetCode150.LinkedLists;

public class LinkedListCycleDetectionTests
{
    [Test]
    public void Case1()
    {
        var head = NodeGenerator.ListNode(new int[] { 3, 2, 0, -4 });
        var tail = head!.next!.next!.next;
        tail!.next = head!.next;

        var solution = new LinkedListCycleDetectionSolution();
        var result = solution.HasCycle(head);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var head = NodeGenerator.ListNode(new int[] { 1, 2 });
        var tail = head!.next;
        tail!.next = head;

        var solution = new LinkedListCycleDetectionSolution();
        var result = solution.HasCycle(head);

        result.Should().BeTrue();
    }

    [Test]
    public void Case3()
    {
        var head = NodeGenerator.ListNode(new int[] { 1 });

        var solution = new LinkedListCycleDetectionSolution();
        var result = solution.HasCycle(head);

        result.Should().BeFalse();
    }
}