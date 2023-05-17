
namespace LeetCode.Tests
{
    /// <summary>
    /// 392. Is Subsequence
    /// https://leetcode.com/problems/is-subsequence/
    /// 
    /// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
    /// A subsequence of a string is a new string that is formed from the original string by deleting 
    /// some (can be none) of the characters without disturbing the relative positions of the remaining characters. 
    /// (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    /// </summary>

    [Companies(Company.Amazon, Company.Google, Company.Uber)]
    [Level(Level.Easy)]
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
}