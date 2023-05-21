
namespace LeetCode.Tests;

/// <summary>
/// 15. 3Sum
/// https://leetcode.com/problems/3sum/
/// 
/// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that
/// i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
/// Notice that the solution set must not contain duplicate triplets.
/// </summary>

[Companies(Company.Adobe, Company.Amazon, Company.Microsoft)]
[Level(Level.Medium)]
public class _15_3Sum_Tests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };

        var solution = new _15_3Sum();
        var result = solution.ThreeSum(nums);

        result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {-1, -1, 2},
                new List<int>() {-1, 0, 1}
            });
    }

    [Test]
    public void Case2()
    {
        var nums = new int[] { 0, 1, 1 };

        var solution = new _15_3Sum();
        var result = solution.ThreeSum(nums);

        result.Should().BeEquivalentTo(new List<IList<int>>());
    }

    [Test]
    public void Case3()
    {
        var nums = new int[] { 0, 0, 0 };

        var solution = new _15_3Sum();
        var result = solution.ThreeSum(nums);

        result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {0, 0, 0},
            });
    }

}