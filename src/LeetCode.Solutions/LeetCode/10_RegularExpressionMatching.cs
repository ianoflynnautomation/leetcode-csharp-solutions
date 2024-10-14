
namespace LeetCode.Solutions;

/// <summary>
/// 10. Regular Expression Matching
/// https://leetcode.com/problems/regular-expression-matching/
/// 
/// Given an input string s and a pattern p, implement regular expression matching with 
/// support for '.' and '*' where:'.' 
/// Matches any single character.​​​​'*' Matches zero or more of the preceding element.
/// The matching should cover the entire input string (not partial).
/// </summary>

[Companies(Company.Amazon, Company.Microsoft, Company.Apple)]
[Level(Level.Hard)]
public class _10_RegularExpressionMatching
{
    public bool IsMatch(string s, string p)
    {
        bool[,] dp = new bool[s.Length + 1, p.Length + 1];
        dp[0, 0] = true;

        for (int i = 0; i <= s.Length; i++)
        {
            for (int j = 1; j <= p.Length; j++)
            {
                if (j > 1 && p[j - 1] == '*')
                {
                    dp[i, j] = dp[i, j - 2] || (i > 0 && (s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1, j]);
                }
                else
                {
                    dp[i, j] = i > 0 && (s[i - 1] == p[j - 1] || p[j - 1] == '.') && dp[i - 1, j - 1];
                }
            }
        }

        return dp[s.Length, p.Length];
    }
}


