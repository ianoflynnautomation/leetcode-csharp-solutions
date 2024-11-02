namespace LeetCode.Tests;

public class _150_EvaluateReversePolishNotation_Tests
{
    [Test]
    public void Case1()
    {
        var tokens = new[] { "2", "1", "+", "3", "*" };

        var solution = new _150_EvaluateReversePolishNotation();
        var result = solution.EvalRPN(tokens);

        result.Should().Be(9);
    }

    [Test]
    public void Case2()
    {
        var tokens = new[] { "4", "13", "5", "/", "+" };

        var solution = new _150_EvaluateReversePolishNotation();
        var result = solution.EvalRPN(tokens);

        result.Should().Be(6);
    }

    [Test]
    public void Case3()
    {
        var tokens = new[] { "10","6","9","3","+","-11","*","/","*","17","+","5","+"};

        var solution = new _150_EvaluateReversePolishNotation();
        var result = solution.EvalRPN(tokens);

        result.Should().Be(22);
    }
}