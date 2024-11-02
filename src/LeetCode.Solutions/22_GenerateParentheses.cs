
namespace LeetCode.Solutions;

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
public class _22_GenerateParentheses
{
    [Approach(Approach.Backtracking)]
    [TimeComplexity("O(4^n / sqrt(n))")]
    [SpaceComplexity("O(n)")]
    public IList<string> GenerateParenthesis(int n)
    {
        var answer = new List<string>();
        backtracking(answer, string.Empty, 0, 0, n);
        return answer;
    }

    private void backtracking(
        List<string> answer,
        string currentString,
        int leftCount,
        int rightCount,
        int n)
    {
        if (currentString.Length == 2 * n)
        {
            answer.Add(currentString); 
            
            return;
        }

        if (leftCount < n)
        {
            backtracking(answer, currentString + '(', leftCount + 1, rightCount, n);
        }

        if (leftCount > rightCount)
        {
            backtracking(answer, currentString + ')', leftCount, rightCount + 1, n);
        }
    }

}