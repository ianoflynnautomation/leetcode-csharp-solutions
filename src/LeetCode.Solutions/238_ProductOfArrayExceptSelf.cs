namespace LeetCode.Solutions;

/// <summary>
/// 238. Product of Array Except Self
/// https://leetcode.com/problems/product-of-array-except-self/
/// Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
/// 
/// </summary>
[Level(Level.Medium)]
public class _238_ProductOfArrayExceptSelf
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(1)")]
    public int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        var result = new int[n];

        // initialize the result array with 1
        for (var i = 0; i < n; i++)
        {
            result[i] = 1;
        }

        // calculate the prefix product
        int prefixProduct = 1;
        for (int i = 0; i < n; i++)
        {
            result[i] *= prefixProduct;
            prefixProduct *= nums[i];
        }

        // calculate the suffix product
        int suffixProduct = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            result[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return result;
    }
}