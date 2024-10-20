using LeetCode.Solutions.NeetCode150.TwoPointers;

namespace LeetCode.Tests.NeetCode150.TwoPointers;

public class ValidPalindromeTests
{
    [Test]
    public void Case1()
    {
        var s = "A man, a plan, a canal: Panama";

        var solution = new ValidPalindromeSolution();
        var result = solution.IsPalindrome(s);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var s = "race a car";

        var solution = new ValidPalindromeSolution();
        var result = solution.IsPalindrome(s);

        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var s = " ";

        var solution = new ValidPalindromeSolution();
        var result = solution.IsPalindrome(s);

        result.Should().BeTrue();
    }
}