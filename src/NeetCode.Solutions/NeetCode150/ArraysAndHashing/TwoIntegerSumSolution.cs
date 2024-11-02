
namespace NeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
///Two Integer Sum
///Given an array of integers nums and an integer target, return the indices i and j such that nums[i] + nums[j] == target and i != j.
///You may assume that every input has exactly one pair of indices i and j that satisfy the condition.
///Return the answer with the smaller index first.

///Example 1:
///Input: 
///nums = [3,4,5,6], target = 7
///Output: [0,1]
///Explanation: nums[0] + nums[1] == 7, so we return [0, 1].

///Example 2:
///Input: nums = [4,5,6], target = 10
///Output: [0,2]

///Example 3:
///Input: nums = [5,5], target = 10
///Output: [0,1]
///Constraints:

///2 <= nums.length <= 1000
///-10,000,000 <= nums[i] <= 10,000,000
///-10,000,000 <= target <= 10,000,000
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Apple)]
[Level(Level.Easy)]
public class TwoIntegerSumSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public int[] TwoSum(int[] nums, int target)
    {
        // <val, index>
        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int result = target - nums[i];

            if (dictionary.ContainsKey(result))
                return [dictionary[result], i];
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
                return [left, right];
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