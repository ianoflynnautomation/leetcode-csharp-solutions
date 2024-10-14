namespace LeetCode.Tests;

public class _8_StringToIntegerAtoi_Tests
{
    [Test]
    public void Case1()
    {
        var s = "42";

        var solution = new _8_StringToIntegerAtoi();
        var result = solution.MyAtoi(s);

        result.Should().Be(42);
    }

    [Test]
    public void Case2()
    {
        var s = "   -42";

        var solution = new _8_StringToIntegerAtoi();
        var result = solution.MyAtoi(s);

        result.Should().Be(-42);
    }

    [Test]
    public void Case3()
    {
        var s = "4193 with words";

        var solution = new _8_StringToIntegerAtoi();
        var result = solution.MyAtoi(s);

        result.Should().Be(4193);     
    }

}