
namespace LeetCode.Tests;
public class _20_ValidParentheses_Tests
{
    [Test]
    public void Case1()
    {
        var s = "()";

        var solution = new _20_ValidParentheses();
        var result = solution.IsValid(s);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var s = "()[]{}";

        var solution = new _20_ValidParentheses();
        var result = solution.IsValid(s);

        result.Should().BeTrue();
    }

    [Test]
    public void Case3()
    {
        var s = "(]";

        var solution = new _20_ValidParentheses();
        var result = solution.IsValid(s);

        result.Should().BeFalse();
    }
}