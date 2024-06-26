
namespace LeetCode.Solutions;

/// <summary>
/// 5. Longest Palindromic Substring
/// https://leetcode.com/problems/longest-palindromic-substring/
///
/// Given a string s, return the longest palindromic substring in s.
/// </summary>

[Companies(Company.Amazon, Company.Cisco, Company.Microsoft)]
[Level(Level.Medium)]
public class _5_LongestPalindromicSubstring
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return s;
        }

        int start = 0, end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandFromMiddle(s, i, i);
            int len2 = ExpandFromMiddle(s, i, i + 1);
            int len = Math.Max(len1, len2);
            if (len > end - start)
            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1);
    }

    private int ExpandFromMiddle(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        return right - left - 1;
    }

}