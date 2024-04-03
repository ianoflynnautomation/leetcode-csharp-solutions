
namespace LeetCode.Tests;

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
                new List<int>() {-1,0,0,1}
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