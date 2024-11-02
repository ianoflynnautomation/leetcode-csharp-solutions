
namespace NeetCode.Tests.NeetCode150.Stack;

public class DailyTemperaturesTests
{
    [Test]
    public void Case1()
    {
        var temperatures = new int[] { 73, 74, 75, 71, 69, 72, 76, 73 };

        var solution = new DailyTemperaturesSolution();
        var result = solution.DailyTemperatures(temperatures);
        result.Should().Equal([1, 1, 4, 2, 1, 1, 0, 0 ]);
    }
}