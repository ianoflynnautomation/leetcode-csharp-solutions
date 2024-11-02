
namespace LeetCode.Solutions;

/// <summary>
/// 1480. Running Sum of 1d Array
/// https://leetcode.com/problems/running-sum-of-1d-array/
/// 
/// Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
/// Return the running sum of nums.
/// </summary>

[Companies(Company.Amazon, Company.Google, Company.Adobe)]
[Level(Level.Easy)]

public class _1480_RunningSumof1dArray
{
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }
}
