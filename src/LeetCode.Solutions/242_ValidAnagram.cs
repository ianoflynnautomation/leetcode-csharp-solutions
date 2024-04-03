namespace LeetCode.Solutions;

/// <summary>
/// 242. Valid Anagram
/// https://leetcode.com/problems/valid-anagram/
/// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
/// Example 1:
/// Input: s = "anagram", t = "nagaram"
/// Output: true
/// Example 2:
/// Input: s = "rat", t = "car"
/// Output: false
/// Constraints:
/// 1 <= s.length, t.length <= 5 * 104
/// s and t consist of lowercase English letters.
/// </summary>

[Level(Level.Easy)]
public class _242_ValidAnagram
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(1)")]
    public bool IsAnagram(string s, string t)
    {
        var dictionary = new Dictionary<char, int>();

        // count the number of each character in s
        foreach (char c in s)
        {
            if (dictionary.ContainsKey(c))
                dictionary[c]++;
            else
                dictionary[c] = 1;
        }

        // decrement the count of each character in t
        foreach (char c in t)
        {
            if (dictionary.ContainsKey(c))
            {
                dictionary[c]--;
                if (dictionary[c] == 0)
                    dictionary.Remove(c);
            }
            else
            {
                // if the character is not in the dictionary, it means it is not an anagram
                return false;
            }
        }

        // if the dictionary is empty, it means all characters in s and t are the same
        return dictionary.Count() == 0;
    }

}