namespace NeetCode.Tests.NeetCode150.Stack;

public class MinimumStackTests
{

    [Test]
    public void Case1()
    {
        var solution = new MinimumStackSolution();
        solution.Push(-2);
        solution.Push(0);
        solution.Push(-3);
        var result1 = solution.GetMin();
        result1.Should().Be(-3);
        solution.Pop();
        var result2 = solution.Top();
        result2.Should().Be(0);
        var result3 = solution.GetMin();
        result3.Should().Be(-2);
    }

    [Test]
    public void Case2()
    {
        var solution = new MinimumStackSolution();
        solution.Push(0);
        solution.Push(1);
        solution.Push(0);
        var result1 = solution.GetMin();
        result1.Should().Be(0);
        solution.Pop();
        var result2 = solution.GetMin();
        result2.Should().Be(0);
    }
}
