
namespace LeetCode.Solutions;

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

public class _20_ValidParentheses
{
    [Approach(Approach.Stacks)]
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public bool IsValid(string s)
    {

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                stack.Pop();
            else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                stack.Pop();
            else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                stack.Pop();

            else stack.Push(c);
        }

        return stack.Count == 0;
    }

}