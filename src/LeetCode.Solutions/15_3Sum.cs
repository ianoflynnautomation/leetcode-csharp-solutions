
namespace LeetCode.Solutions;

/// <summary>
/// 15. 3Sum
/// https://leetcode.com/problems/3sum/
/// 
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that
/// i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// Notice that the solution set must not contain duplicate triplets.
/// </summary>

[Companies(Company.Adobe, Company.Amazon, Company.Microsoft)]
[Level(Level.Medium)]
public class _15_3Sum
{
    [TimeComplexity(" O(n^2)")]
    [SpaceComplexity("O(1)")]
    public IList<IList<int>> ThreeSum(int[] nums)
    {

        var result = new List<IList<int>>();

        if (nums == null || nums.Length < 3) return result;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            //Skip duplicates for first element
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // Skip duplicates for second element
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    // Skip duplicates for third element
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < 0) { left++; }
                else { right--; }
            }
        }

        return result;
    }

}