
namespace LeetCode.Tests;

public class _409_LongestPalindrome_Tests
{
    [Test]
    public void Case1()
    {
        var s = "abccccdd";

        var solution = new _409_LongestPalindrome();
        var result = solution.LongestPalindrome(s);

        result.Should().Be(7);
    }

    [Test]
    public void Case2()
    {
        var s = "a";

        var solution = new _409_LongestPalindrome();
        var result = solution.LongestPalindrome(s);

        result.Should().Be(1);
    }

}