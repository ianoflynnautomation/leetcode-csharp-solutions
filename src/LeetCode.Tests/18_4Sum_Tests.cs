
namespace LeetCode.Tests;

/// <summary>
/// 18. 4Sum
/// https://leetcode.com/problems/4sum/
/// 
/// Given an array nums of n integers, return an array of all the unique quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
/// 0 <= a, b, c, d < n
/// a, b, c, and d are distinct.
/// nums[a] + nums[b] + nums[c] + nums[d] == target
/// You may return the answer in any order.
/// 
/// Constraints:
/// 1 <= nums.length <= 200
/// -109 <= nums[i] <= 109
/// -109 <= target <= 109
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Meta)]
[Level(Level.Medium)]
public class _18_4Sum_Tests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { 1, 0, -1, 0, -2, 2 };
        var target = 0;

        var solution = new _18_4Sum();
        var result = solution.FourSum(nums, target);

        result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {-2,-1,1,2},
                new List<int>() {-2,0,0,2},
                new List<int>{-1,0,0,1}
            });

    }

    [Test]
    public void Case2()
    {
        var nums = new int[] { 2, 2, 2, 2, 2 };
        var target = 8;

        var solution = new _18_4Sum();
        var result = solution.FourSum(nums, target);

        result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {2,2,2,2}
            });

    }
}