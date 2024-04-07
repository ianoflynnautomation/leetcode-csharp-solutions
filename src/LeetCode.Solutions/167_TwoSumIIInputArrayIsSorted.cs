namespace LeetCode.Solutions;

/// <summary>
/// 167. Two Sum II - Input array is sorted
/// https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, 
/// find two numbers such that they add up to a specific target number. 
/// Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.
/// Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.
/// The tests are generated such that there is exactly one solution. You may not use the same element twice.
/// Your solution must use only constant extra space.
/// </summary>

[Level(Level.Medium)]
public class _167_TwoSumIIInputArrayIsSorted
{
     public int[] TwoSum(int[] numbers, int target) {
        
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right){

            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                return new int[] { left + 1, right + 1 };
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

        return new int[2];
    }
}