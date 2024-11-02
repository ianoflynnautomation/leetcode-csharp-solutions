namespace NeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
/// Given an integer array nums, return an array output where output[i] is the product of all the elements of nums except nums[i].
///Each product is guaranteed to fit in a 32-bit integer.
///Follow-up: Could you solve it in O(n) O(n) time without using the division operation?
///
///Example 1:
///Input: nums = [1,2,4,6]
///Output: [48,24,12,8]
///
///Example 2:
///Input: nums = [-1,0,1,2,3]
///Output: [0,-6,0,0,0]
///
//Constraints:
///2 <= nums.length <= 1000
///-20 <= nums[i] <= 20
/// </summary>
[Level(Level.Medium)]
public class ProductOfArrayExceptSelfSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(1)")]
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;

        int[] result = new int[n];
        int[] prefix = new int[n];
        int[] suffix = new int[n];

        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;

        for (int i = 1; i < n; i++)
        {
            prefix[i] = nums[i - 1] * prefix[i - 1];
        }

        for (int i = n - 2; i >= 0; i--)
        {
            suffix[i] = nums[i + 1] * suffix[i + 1];
        }

        for (int i = 0; i < n; i++)
        {
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}