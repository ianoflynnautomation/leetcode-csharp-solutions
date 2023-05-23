
namespace LeetCode.Tests
{
    /// <summary>
    /// 20. Valid Parentheses
    /// https://leetcode.com/problems/valid-parentheses/
    /// 
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    /// An input string is valid if:
    /// Open brackets must be closed by the same type of brackets.
    /// Open brackets must be closed in the correct order.
    /// Every close bracket has a corresponding open bracket of the same type.
    ///
    /// Constraints:
    /// 1 <= s.length <= 104
    /// s consists of parentheses only '()[]{}'.
    /// </summary>
    
    public class _20_ValidParentheses_Tests
    {
        [Test]
        public void Case1()
        {
            var s = "()";

            var solution = new _20_ValidParentheses();
            var result = solution.IsValid(s);

            result.Should().BeTrue();
        }

        [Test]
        public void Case2()
        {
            var s = "()[]{}";

            var solution = new _20_ValidParentheses();
            var result = solution.IsValid(s);

            result.Should().BeTrue();
        }

        [Test]
        public void Case3()
        {
            var s = "(]";

            var solution = new _20_ValidParentheses();
            var result = solution.IsValid(s);

            result.Should().BeFalse();
        }
    }
}