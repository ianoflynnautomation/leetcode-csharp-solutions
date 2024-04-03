
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
    public int[] TwoSum(int[] nums, int target)
    {
        var dic = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(target - nums[i]))
                return new int[] { i, dic[target - nums[i]] };
            else if (!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], i);
        }

        return new int[2];
    }

}