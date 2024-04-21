namespace LeetCode.Solutions;
/// <summary>
/// 153. Find Minimum in Rotated Sorted Array
/// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
/// Suppose an array of length n sorted in ascending order is rotated between 1 and n times.
/// Given the sorted rotated array nums of unique elements, return the minimum element of this array.
/// You must write an algorithm that runs in O(log n) time.
/// </summary>

[Level(Level.Medium)]
public class _153_FindMinimumInRotatedSortedArray
{
    public int FindMin(int[] nums)
    {

        int left = 0;
        int right = nums.Length - 1;

        // Binary Search
        while (left < right)
        {
            // calculate mid point
            int mid = left + (right - left) / 2;

            // If mid-point element is greater than the last element
            // of the array, then the minimum element must be in the
            // right half of the array, so we update left pointer
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            // Otherwise, the minimum element must be in the left half
            // of the array, so we update right pointer
            else
            {
                right = mid;
            }
        }
        // At the end of the while loop, left pointer points to the
        // minimum element of the array, which is the answer
        return nums[left];
    }
}