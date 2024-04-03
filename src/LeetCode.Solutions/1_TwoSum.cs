
namespace LeetCode.Solutions;

/// <summary>
/// 1. Two Sum
/// https://leetcode.com/problems/two-sum/
/// 
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// You can return the answer in any order.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Apple)]
[Level(Level.Easy)]
public class _1_TwoSum
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public int[] TwoSum(int[] nums, int target)
    {
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];

            if (dictionary.ContainsKey(result))
                return new int[] { dictionary[result], i };
            else
                dictionary[nums[i]] = i;
        }
        // no solution found.
        return null;
    }

    [TimeComplexity("O(n log n)")]
    [SpaceComplexity("O(1)")]
    public int[] TwoSum2(int[] nums, int target)
    {
        // Sort the array
        Array.Sort(nums);

        // Initialize two pointers
        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int sum = nums[left] + nums[right];
            if (sum == target)
            {
                return new int[] { left, right };
            }
            else if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        // No solution found
        return null;
    }
}