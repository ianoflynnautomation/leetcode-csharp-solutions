
namespace LeetCode.Tests
{
    /// <summary>
    /// 704. Binary Search
    /// https://leetcode.com/problems/binary-search/
    /// 
    /// Given an array of integers nums which is sorted in ascending order, and an integer target, 
    /// write a function to search target in nums. 
    /// If target exists, then return its index. Otherwise, return -1.
    /// You must write an algorithm with O(log n) runtime complexity.
    /// </summary>
    
    [Companies("Amazon, Apple, Adobe")]
    [Level("Easy")]
    public class _704_BinarySearch_Tests
    {
        [Test]
        public void Case1()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };

            var solution = new _704_BinarySearch();
            var result = solution.Search(nums, 9);

            result.Should().Be(4);
        }

        [Test]
        public void Case2()
        {
            var nums = new int[] { -1, 0, 3, 5, 9, 12 };

            var solution = new _704_BinarySearch();
            var result = solution.Search(nums, 2);

            result.Should().Be(-1);
        }

    }
}