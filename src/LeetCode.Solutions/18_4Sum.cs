
namespace LeetCode.Solutions;

/// <summary>
/// 18. 4Sum
/// https://leetcode.com/problems/4sum/
/// 
/// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
/// 0 <= a, b, c, d < n
/// a, b, c, and d are distinct.
/// nums[a] + nums[b] + nums[c] + nums[d] == target
/// You may return the answer in any order.
/// 
/// Constraints:
/// 1 <= nums.length <= 200
/// -109 <= nums[i] <= 109
/// -109 <= target <= 109
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Meta)]
[Level(Level.Medium)]
public class _18_4Sum
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {

        var results = new List<IList<int>>();
        if (nums == null || nums.Length < 4) return results;

        Array.Sort(nums);

        for (var i = 0; i < nums.Length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (var j = i + 1; j < nums.Length - 2; j++)
            {
                if (j > i + 1 && nums[j] == nums[j - 1]) continue;
                long sum = nums[i] + nums[j];
                var left = j + 1;
                var right = nums.Length - 1;

                while (left < right)
                {
                    long total = sum + nums[left] + nums[right];

                    if (total == target)
                    {
                        results.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                        left++;
                        right--;
                        while (left < right && nums[left] == nums[left - 1]) left++;
                        while (left < right && nums[right] == nums[right + 1]) right--;
                    }
                    else if (total < target)
                        left++;
                    else
                        right--;

                }
            }
        }

        return results;
    }

}