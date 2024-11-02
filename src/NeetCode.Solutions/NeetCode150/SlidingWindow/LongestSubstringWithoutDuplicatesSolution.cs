
namespace NeetCode.Solutions.NeetCode150.SlidingWindow;

[Level(Level.Medium)]
public class LongestSubstringWithoutDuplicatesSolution
{
    public int LengthOfLongestSubstring(string s)
    {
        var hashSet = new HashSet<char>(); 

        int result = 0;
        int left = 0;

        for(int i = 0; i < s.Length; i++)
        {
            while(hashSet.Contains(s[i]))
            {
                hashSet.Remove(s[left]);
                left++;
            }

            hashSet.Add(s[i]);
            result = Math.Max(result, i - left + 1);
        }

        return result;
    }
}