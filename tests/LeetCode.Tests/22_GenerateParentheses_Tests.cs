
namespace LeetCode.Tests;
public class _22_GenerateParentheses_Tests
{
    [Test]
    public void Case1()
    {
        var n = 3;

        var solution = new _22_GenerateParentheses();
        var result = solution.GenerateParenthesis(n);

        result.Should().BeEquivalentTo(new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" });
    }

    [Test]
    public void Case2()
    {
        var n = 1;

        var solution = new _22_GenerateParentheses();
        var result = solution.GenerateParenthesis(n);

        result.Should().BeEquivalentTo(new string[] { "()" });
    }

    [Test]
    public void Case3()
    {
        var n = 2;

        var solution = new _22_GenerateParentheses();
        var result = solution.GenerateParenthesis(n);

        result.Should().BeEquivalentTo(new string[] { "(())", "()()" });
    }

}