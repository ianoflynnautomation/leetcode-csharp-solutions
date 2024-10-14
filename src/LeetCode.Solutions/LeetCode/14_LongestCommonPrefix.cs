
namespace LeetCode.Solutions;

/// <summary>
/// 14. Longest Common Prefix
/// https://leetcode.com/problems/longest-common-prefix/
/// 
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// </summary>

[Companies(Company.Adobe, Company.Amazon, Company.Bloomberg)]
[Level(Level.Easy)]
public class _14_LongestCommonPrefix
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";

        // Take first item as prefix
        string prefix = strs[0];

        // Loop through all of the items in the list. Start with the second item
        for (int i = 1; i < strs.Length; i++)
        {
            // Remove last prefix letter until both words have the 
            // same beginning prefix
            while (strs[i].IndexOf(prefix) != 0)
            {
                // Remove the last letter
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If we remove every letter it means there is no common prefix
                if (!prefix.Any()) return "";
            }
        }

        return prefix;
    }
}