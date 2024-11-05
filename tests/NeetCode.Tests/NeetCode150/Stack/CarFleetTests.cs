
namespace NeetCode.Tests.NeetCode150.Stack;

public class CarFleetTests
{
    [Test]
    public void Case1()
    {
        var target = 12;
        var position = new int[] { 1, 4 };
        var speed = new int[] { 3, 2 };

        var solution = new CarFleetSolution();
        var result = solution.CarFleet(target, position, speed);
        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var target = 10;
        var position = new int[] { 4, 1, 0, 7 };
        var speed = new int[] {2, 2, 1, 1 };

        var solution = new CarFleetSolution();
        var result = solution.CarFleet(target, position, speed);
        result.Should().Be(3);
    }
}