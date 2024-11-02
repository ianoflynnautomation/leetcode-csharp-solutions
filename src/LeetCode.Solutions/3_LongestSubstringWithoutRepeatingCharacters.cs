
namespace LeetCode.Solutions;

/// <summary>
/// 3. Longest Substring Without Repeating Characters
/// https://leetcode.com/problems/longest-substring-without-repeating-characters/
/// 
/// Given a string s, find the length of the longest substring without repeating characters.
/// </summary>

[Companies(Company.Amazon, Company.Bloomberg, Company.Apple)]
[Level(Level.Medium)]
public class _3_LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLen = 0;
        var dict = new Dictionary<char, int>();

        for (int i = 0, j = 0; j < s.Length; j++)
        {
            if (dict.ContainsKey(s[j]))
            {
                i = Math.Max(dict[s[j]], i);
            }

            maxLen = Math.Max(maxLen, j - i + 1);
            dict[s[j]] = j + 1;
        }

        return maxLen;
    }

}
