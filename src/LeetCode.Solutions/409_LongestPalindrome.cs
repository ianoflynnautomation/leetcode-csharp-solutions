
namespace LeetCode.Solutions;

/// <summary>
/// 409. Longest Palindrome
/// https://leetcode.com/problems/longest-palindrome/
/// 
/// Given a string s which consists of lowercase or uppercase letters, return the length 
/// of the longest palindrome that can be built with those letters.
/// Letters are case sensitive, for example, "Aa" is not considered a palindrome here.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Microsoft)]
[Level(Level.Easy)]
public class _409_LongestPalindrome
{
    public int LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;

        int[] counts = new int[128];
        foreach (char c in s)
        {
            counts[c]++;
        }

        int longest = 0;
        bool hasOdd = false;
        foreach (int count in counts)
        {
            if (count % 2 == 0)
            {
                longest += count;
            }
            else
            {
                longest += count - 1;
                hasOdd = true;
            }
        }

        return hasOdd ? longest + 1 : longest;
    }
}