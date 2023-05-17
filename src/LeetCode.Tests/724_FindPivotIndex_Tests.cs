
namespace LeetCode.Tests
{
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
    public class _724_FindPivotIndex_Tests
    {
        [Test]
        public void Case1()
        {
            var testData = new int[] { 1, 7, 3, 6, 5, 6 };

            var solution = new _724_FindPivotIndex();
            var result = solution.PivotIndex(testData);

            result.Should().Be(3);
        }

        [Test]
        public void Case2()
        {
            var testData = new int[] { 1, 2, 3 };

            var solution = new _724_FindPivotIndex();
            var result = solution.PivotIndex(testData);

            result.Should().Be(-1);
        }

        [Test]
        public void Case3()
        {
            var testData = new int[] { 2, 1, -1 };

            var solution = new _724_FindPivotIndex();
            var result = solution.PivotIndex(testData);

            result.Should().Be(0);
        }
    }
}