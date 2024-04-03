
namespace LeetCode.Tests;

public class _392_IsSubsequence_Tests
{
    [Test]
    public void Case1()
    {
        var s = "abc";
        var t = "ahbgdc";

        var solution = new _392_IsSubsequence();
        var result = solution.IsSubsequence(s, t);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var s = "axc";
        var t = "ahbgdc";

        var solution = new _392_IsSubsequence();
        var result = solution.IsSubsequence(s, t);

        result.Should().BeFalse();
    }
    
}
