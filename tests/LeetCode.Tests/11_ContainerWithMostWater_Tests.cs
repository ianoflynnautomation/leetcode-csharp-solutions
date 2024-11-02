
namespace LeetCode.Tests;

public class _11_ContainerWithMostWater_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _11_ContainerWithMostWater();
        var result = solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

        result.Should().Be(49);
    }

    [Test]
    public void Case2()
    {
        var solution = new _11_ContainerWithMostWater();
        var result = solution.MaxArea(new int[] { 1, 1 });

        result.Should().Be(1);

    }

}
