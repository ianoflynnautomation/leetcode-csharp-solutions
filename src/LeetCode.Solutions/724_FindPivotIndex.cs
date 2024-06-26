
namespace LeetCode.Solutions;

/// <summary>
/// 724. Find Pivot Index
/// https://leetcode.com/problems/find-pivot-index/
/// 
/// Given an array of integers nums, calculate the pivot index of this array.
/// The pivot index is the index where the sum of all the numbers strictly to the left of the 
/// index is equal to the sum of all the numbers strictly to the index's right.
/// If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. 
/// This also applies to the right edge of the array.
/// Return the leftmost pivot index. If no such index exists, return -1.
/// </summary>

[Companies(Company.Amazon, Company.Meta, Company.GoldmanSachs)]
[Level(Level.Easy)]
public class _724_FindPivotIndex
{
    public int PivotIndex(int[] nums)
    {
        int sum = nums.Sum();
        int leftSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == sum - leftSum - nums[i])
            {
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}