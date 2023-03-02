
namespace LeetCode.Solutions
{
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
}