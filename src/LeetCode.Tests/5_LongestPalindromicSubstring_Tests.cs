
namespace LeetCode.Tests;

/// <summary>
/// 5. Longest Palindromic Substring
/// https://leetcode.com/problems/longest-palindromic-substring/
///
/// Given a string s, return the longest palindromic substring in s.
/// </summary>

[Companies(Company.Amazon, Company.Cisco, Company.Microsoft)]
[Level(Level.Medium)]
public class _5_LongestPalindromicSubstring_Tests
{
    [Test]
    public void Case1()
    {
        var s = "babad";

        var solution = new _5_LongestPalindromicSubstring();
        var result = solution.LongestPalindrome(s);

        result.Should().Be("aba");
    }

    [Test]
    public void Case2()
    {
        var s = "cbbd";

        var solution = new _5_LongestPalindromicSubstring();
        var result = solution.LongestPalindrome(s);

        result.Should().Be("bb");
    }

}
