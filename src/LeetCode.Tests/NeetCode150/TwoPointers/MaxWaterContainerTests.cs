
using LeetCode.Solutions.NeetCode150.TwoPointers;

namespace LeetCode.Tests.NeetCode150.TwoPointers;

public class MaxWaterContainerTests
{
    [Test]
    public void Case1()
    {
        var solution = new MaxWaterContainerSolution();
        var result = solution.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]);

        result.Should().Be(49);
    }

    [Test]
    public void Case2()
    {
        var solution = new MaxWaterContainerSolution();
        var result = solution.MaxArea([1, 1]);

        result.Should().Be(1);
    }

}
