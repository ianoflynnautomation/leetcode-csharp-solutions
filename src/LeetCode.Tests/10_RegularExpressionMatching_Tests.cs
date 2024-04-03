
namespace LeetCode.Tests;
public class _10_RegularExpressionMatching_Tests
{
    [Test]
    public void Case1()
    {
        var s = "aa";
        var p = "a";

        var solution = new _10_RegularExpressionMatching();
        var result = solution.IsMatch(s, p);

        result.Should().BeFalse();
    }

    [Test]
    public void Case2()
    {
        var s = "aa";
        var p = "a*";

        var solution = new _10_RegularExpressionMatching();
        var result = solution.IsMatch(s, p);

        result.Should().BeTrue();
    }

    [Test]
    public void Case3()
    {
        var s = "ab";
        var p = ".*";

        var solution = new _10_RegularExpressionMatching();
        var result = solution.IsMatch(s, p);

        result.Should().BeTrue();
    }

}
