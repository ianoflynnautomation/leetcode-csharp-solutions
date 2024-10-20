using LeetCode.Solutions.NeetCode150.ArraysAndHashing;

namespace LeetCode.Tests.NeetCode150.TwoPointers;

public class TrappingRainWaterTests
{
    [Test]
    public void Case1()
    {
        var solution = new TrappingRainWaterSolution();
        var result = solution.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);

        result.Should().Be(6);
    }

    [Test]
    public void Case2()
    {
        var solution = new TrappingRainWaterSolution();
        var result = solution.Trap([4, 2, 0, 3, 2, 5]);

        result.Should().Be(9);
    }

    [Test]
    public void Case3()
    {
        var solution = new TrappingRainWaterSolution();
        var result = solution.Trap([1, 2, 3, 4, 5]);

        result.Should().Be(0);
    }

    [Test]
    public void Case4()
    {
        var solution = new TrappingRainWaterSolution();
        var result = solution.Trap([5, 4, 3, 2, 1]);

        result.Should().Be(0);
    }
}