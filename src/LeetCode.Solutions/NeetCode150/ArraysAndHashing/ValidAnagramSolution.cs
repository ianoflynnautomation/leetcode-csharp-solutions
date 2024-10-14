
namespace LeetCode.Solutions.NeetCode150.ArraysAndHashing;
/// <summary>
/// Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.
/// 
/// An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.
///
/// Example 1:
/// Input: s = "racecar", t = "carrace"
/// Output: true
/// Example 2:
/// Input: s = "jar", t = "jam"
/// Output: false
// Constraints:
// s and t consist of lowercase English letters.
/// </summary>
[Level(Level.Easy)]
public class ValidAnagramSolution
{
    public bool IsAnagram(string s, string t)
    { 
        var dictionary = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (dictionary.ContainsKey(c))
                dictionary[c]++;
            else
                dictionary[c] = 1;
        }

        foreach (char c in t)
        {
            if(dictionary.ContainsKey(c))
            {
                dictionary[c]--;
                if (dictionary[c] == 0)
                    dictionary.Remove(c);
            }
        }

        return dictionary.Count() == 0;

    }

}