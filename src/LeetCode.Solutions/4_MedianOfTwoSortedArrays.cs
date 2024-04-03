
namespace LeetCode.Solutions;

/// <summary>
/// 4. Median of Two Sorted Arrays
/// https://leetcode.com/problems/median-of-two-sorted-arrays/
/// 
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n)).
/// </summary>

[Companies(Company.Amazon, Company.Bloomberg, Company.Adobe)]
[Level(Level.Hard)]
public class _4_MedianOfTwoSortedArrays
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var s = nums1.Concat(nums2).OrderBy(x => x).ToArray();
        if (s.Length % 2 != 0)
        {
            return s[s.Length / 2];
        }
        return (double)(s[s.Length / 2] + s[(s.Length / 2) - 1]) / 2;

    }
}
