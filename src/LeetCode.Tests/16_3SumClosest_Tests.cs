
namespace LeetCode.Tests
{
    /// <summary>
    /// 16. 3Sum Closest
    /// https://leetcode.com/problems/3sum-closest/
    /// 
    /// Given an integer array nums of length n and an integer target, find three integers in nums such that the sum is closest to target.
    /// Return the sum of the three integers.
    /// You may assume that each input would have exactly one solution.
    /// </summary>

    [Companies(Company.Adobe, Company.Amazon, Company.Meta)]
    [Level(Level.Medium)]
    public class _16_3SumClosest_Tests
    {
        [Test]
        public void Case1()
        {
            var nums = new int[] { -1, 2, 1, -4 };
            var target = 1;

            var solution = new _16_3SumClosest();
            var result = solution.ThreeSumClosest(nums, target);

            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var nums = new int[] { 0, 0, 0 };
            var target = 1;

            var solution = new _16_3SumClosest();
            var result = solution.ThreeSumClosest(nums, target);

            result.Should().Be(0);
        }
    }
}