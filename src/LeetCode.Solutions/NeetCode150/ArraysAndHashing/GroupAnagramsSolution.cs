
namespace LeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
/// 49. Group Anagrams
/// https://leetcode.com/problems/group-anagrams/
/// Given an array of strings strs, group the anagrams together. You can return the answer in any order.
/// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, 
/// typically using all the original letters exactly once.
/// 
/// Example 1:

/// Input: strs = ["eat","tea","tan","ate","nat","bat"]
/// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
/// Example 2:

/// Input: strs = [""]
/// Output: [[""]]
/// Example 3:

/// Input: strs = ["a"]
/// Output: [["a"]]
 

/// Constraints:

/// 1 <= strs.length <= 104
/// 0 <= strs[i].length <= 100
/// strs[i] consists of lowercase English letters.
/// </summary>

[Level(Level.Medium)]
public class GroupAnagramsSolution
{
    [TimeComplexity("O(n * m log m)")]
    [SpaceComplexity("O(n * k)")]
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var anagramGroups = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {

            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);
            
            // Linq solution
            //var sortedStr = new string(str.OrderBy(c => c).ToArray());

            if (!anagramGroups.ContainsKey(sortedStr))
            {
                anagramGroups[sortedStr] = new List<string>();
            }

            anagramGroups[sortedStr].Add(str);
        }

        return anagramGroups.Values.ToList<IList<string>>();
    }
}