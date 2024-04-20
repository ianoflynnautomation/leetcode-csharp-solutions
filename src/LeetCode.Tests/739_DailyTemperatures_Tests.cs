
namespace LeetCode.Tests;

public class _739_DailyTemperatures_Tests
{
    [Test]
    public void Case1()
    {
        var temperatures = new[] { 73, 74, 75, 71, 69, 72, 76, 73 };

        var solution = new _739_DailyTemperatures();
        var result = solution.DailyTemperatures(temperatures);

        result.Should().Equal(1, 1, 4, 2, 1, 1, 0, 0);
    }

    [Test]
    public void Case2()
    {
        var temperatures = new[] { 30, 40, 50, 60 };

        var solution = new _739_DailyTemperatures();
        var result = solution.DailyTemperatures(temperatures);

        result.Should().Equal(1, 1, 1, 0);
    }

    [Test]
    public void Case3()
    {
        var temperatures = new[] { 30, 60, 90 };

        var solution = new _739_DailyTemperatures();
        var result = solution.DailyTemperatures(temperatures);

        result.Should().Equal(1, 1, 0);
    }
}