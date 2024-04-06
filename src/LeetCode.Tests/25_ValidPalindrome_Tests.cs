namespace LeetCode.Tests;

public class _25_ValidPalindrome_Tests
{
    [Test]
    public void Case1()
    {
        var s = "A man, a plan, a canal: Panama";

        var solution = new _25_ValidPalindrome();
        var result = solution.IsPalindrome(s);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var s = "race a car";

        var solution = new _25_ValidPalindrome();
        var result = solution.IsPalindrome(s);

        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var s = " ";

        var solution = new _25_ValidPalindrome();
        var result = solution.IsPalindrome(s);

        result.Should().BeTrue();
    }
}