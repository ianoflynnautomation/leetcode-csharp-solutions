
namespace LeetCode.Tests;

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