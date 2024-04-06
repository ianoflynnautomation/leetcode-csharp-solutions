namespace LeetCode.Solutions;

/// <summary>
/// 128. Longest Consecutive Sequence
/// https://leetcode.com/problems/longest-consecutive-sequence/
/// Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
/// You must write an algorithm that runs in O(n) time.
/// </summary>
public class _128_LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var set = new HashSet<int>(nums);
        var longestStreak = 0;

        foreach (var num in set)
        {
            if (!set.Contains(num - 1))
            {
                var currentNum = num;
                var currentStreak = 1;

                while (set.Contains(currentNum + 1))
                {
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }
}