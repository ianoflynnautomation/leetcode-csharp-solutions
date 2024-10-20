
using LeetCode.Solutions.NeetCode150.TwoPointers;

namespace LeetCode.Tests.NeetCode150.TwoPointers;

public class ThreeIntegerSumTests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { -1, 0, 1, 2, -1, -4 };

        var solution = new ThreeIntegerSumSolution();
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

        var solution = new ThreeIntegerSumSolution();
        var result = solution.ThreeSum(nums);

        result.Should().BeEquivalentTo(new List<IList<int>>());
    }

    [Test]
    public void Case3()
    {
        var nums = new int[] { 0, 0, 0 };

        var solution = new ThreeIntegerSumSolution();
        var result = solution.ThreeSum(nums);

        result.Should().BeEquivalentTo(new List<IList<int>>()
            {
                new List<int>() {0, 0, 0},
            });
    }

}