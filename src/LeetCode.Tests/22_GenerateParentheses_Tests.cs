
namespace LeetCode.Tests
{
    /// <summary>
    /// 22. Generate Parentheses
    /// https://leetcode.com/problems/generate-parentheses/
    /// 
    /// Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
    /// 
    /// Constraints:
    /// 1 <= n <= 8
    /// </summary>
    
    [Companies(Company.Adobe, Company.Apple, Company.TikTok)]
    [Level(Level.Medium)]
    public class _22_GenerateParentheses_Tests
    {
        [Test]
        public void Case1()
        {
            var n = 3;

            var solution = new _22_GenerateParentheses();
            var result = solution.GenerateParenthesis(n);

            result.Should().BeEquivalentTo(new string[] { "((()))", "(()())", "(())()", "()(())", "()()()" });
        }

        [Test]
        public void Case2()
        {
            var n = 1;

            var solution = new _22_GenerateParentheses();
            var result = solution.GenerateParenthesis(n);

            result.Should().BeEquivalentTo(new string[] { "()" });
        }

        [Test]
        public void Case3()
        {
            var n = 2;

            var solution = new _22_GenerateParentheses();
            var result = solution.GenerateParenthesis(n);

            result.Should().BeEquivalentTo(new string[] { "(())", "()()" });
        }
        
    }
}