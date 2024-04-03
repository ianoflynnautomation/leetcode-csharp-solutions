
namespace LeetCode.Solutions;

/// <summary>
/// 205. Isomorphic Strings
/// https://leetcode.com/problems/isomorphic-strings/
/// 
/// Given two strings s and t, determine if they are isomorphic.
/// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
/// All occurrences of a character must be replaced with another character while preserving the order of characters. 
/// No two characters may map to the same character, but a character may map to itself.
/// </summary>

[Companies(Company.Microsoft, Company.LinkedIn, Company.Amazon)]
[Level(Level.Easy)]
public class _205_IsomorphicStrings
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var sMap = new Dictionary<char, char>();
        var tMap = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++)
        {
            char sChar = s[i];
            char tChar = t[i];

            if (sMap.ContainsKey(sChar))
            {
                if (sMap[sChar] != tChar)
                {
                    return false;
                }
            }
            else
            {
                if (tMap.ContainsKey(tChar))
                {
                    return false;
                }

                sMap[sChar] = tChar;
                tMap[tChar] = sChar;
            }
        }

        return true;
    }

}