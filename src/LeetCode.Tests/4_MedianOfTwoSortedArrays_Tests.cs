
namespace LeetCode.Tests
{
    /// <summary>
    /// 4. Median of Two Sorted Arrays
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// 
    /// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
    /// The overall run time complexity should be O(log (m+n)).
    /// </summary>

    [Companies(Company.Amazon, Company.Bloomberg, Company.Adobe)]
    [Level(Level.Hard)]
    public class _4_MedianOfTwoSortedArrays_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _4_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 });

            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var solution = new _4_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 });

            result.Should().Be(2.5);

        }

    }
}