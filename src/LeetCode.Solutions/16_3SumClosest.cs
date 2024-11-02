
namespace LeetCode.Solutions;

/// <summary>
/// 16. 3Sum Closest
/// https://leetcode.com/problems/3sum-closest/
/// 
/// Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
/// Return the sum of the three integers.
/// You may assume that each input would have exactly one solution.
/// </summary>

[Companies(Company.Adobe, Company.Amazon, Company.Meta)]
[Level(Level.Medium)]
public class _16_3SumClosest
{
    [TimeComplexity(" O(n^2)")]
    [SpaceComplexity("O(1)")]
    public int ThreeSumClosest(int[] nums, int target)
    {

        int closestSum = nums[0] + nums[1] + nums[2];
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int low = i + 1;
            int high = nums.Length - 1;

            while (low < high)
            {
                int sum = nums[i] + nums[low] + nums[high];
                if (sum == target) return sum;

                if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    closestSum = sum;

                if (sum < target) low++;
                else high--;
            }
        }
        return closestSum;
    }
}