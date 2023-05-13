
namespace LeetCode.Tests
{
    /// <summary>
    /// 409. Longest Palindrome
    /// https://leetcode.com/problems/longest-palindrome/
    /// 
    /// Given a string s which consists of lowercase or uppercase letters, return the length 
    /// of the longest palindrome that can be built with those letters.
    /// Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
    /// </summary>

    [Companies("Amazon, Apple, Microsoft")]
    [Level("Easy")]
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
}