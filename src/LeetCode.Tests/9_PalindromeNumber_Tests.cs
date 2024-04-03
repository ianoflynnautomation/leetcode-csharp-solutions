
namespace LeetCode.Tests;

public class _9_PalindromeNumber_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _9_PalindromeNumber();
        var result = solution.IsPalindrome(121);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new _9_PalindromeNumber();
        var result = solution.IsPalindrome(-121);

        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var solution = new _9_PalindromeNumber();
        var result = solution.IsPalindrome(10);

        result.Should().BeFalse();
    }

}