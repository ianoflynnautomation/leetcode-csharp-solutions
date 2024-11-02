
namespace LeetCode.Solutions;

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
public class _392_IsSubsequence
{
    public bool IsSubsequence(string s, string t)
    {
        int sIndex = 0;
        int tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {

            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }

            tIndex++;
        }
        return sIndex == s.Length;
    }
}