
namespace LeetCode.Solutions
{
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
}