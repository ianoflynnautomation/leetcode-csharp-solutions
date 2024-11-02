namespace NeetCode.Tests.NeetCode150.Stack;

public class EvaluateReversePolishNotationTests
{
    [Test]
    public void Case1()
    {
        var tokens = new string[] { "2", "1", "+", "3", "*" };

        var solution = new EvaluateReversePolishNotationSolution();
        var result = solution.EvalRPN(tokens);
        result.Should().Be(9);
    }

    [Test]
    public void Case2()
    {
        var tokens = new string[] { "1", "2", "+", "3", "*", "4", "-" };

        var solution = new EvaluateReversePolishNotationSolution();
        var result = solution.EvalRPN(tokens);
        result.Should().Be(5);
    }
}