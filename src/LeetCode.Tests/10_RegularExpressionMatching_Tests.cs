
namespace LeetCode.Tests
{
    /// <summary>
    /// 10. Regular Expression Matching
    /// https://leetcode.com/problems/regular-expression-matching/
    /// 
    /// Given an input string s and a pattern p, implement regular expression matching with 
    /// support for '.' and '*' where:'.' 
    /// Matches any single character.​​​​'*' Matches zero or more of the preceding element.
    /// The matching should cover the entire input string (not partial).
    /// </summary>
    
    [Companies("Amazon, Microsoft, Apple")]
    [Level("Hard")]
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
}