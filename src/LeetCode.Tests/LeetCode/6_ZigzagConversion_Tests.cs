
namespace LeetCode.Tests;
public class _6_ZigzagConversion_Tests
{
    [Test]
    public void Case1()
    {
        var s = "PAYPALISHIRING";
        var numRows = 3;

        var solution = new _6_ZigzagConversion();
        var result = solution.Convert(s, numRows);

        result.Should().Be("PAHNAPLSIIGYIR");
    }

    [Test]
    public void Case2()
    {
        var s = "PAYPALISHIRING";
        var numRows = 4;

        var solution = new _6_ZigzagConversion();
        var result = solution.Convert(s, numRows);

        result.Should().Be("PINALSIGYAHRPI");
    }

    [Test]
    public void Case3()
    {
        var s = "A";
        var numRows = 1;

        var solution = new _6_ZigzagConversion();
        var result = solution.Convert(s, numRows);

        result.Should().Be("A");
    }

}
