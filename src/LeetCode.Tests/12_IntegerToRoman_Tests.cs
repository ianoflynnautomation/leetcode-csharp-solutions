
namespace LeetCode.Tests;

public class _12_IntegerToRoman_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _12_IntegerToRoman();
        var result = solution.IntToRoman(3);

        result.Should().Be("III");
    }

    [Test]
    public void Case2()
    {
        var solution = new _12_IntegerToRoman();
        var result = solution.IntToRoman(58);

        result.Should().Be("LVIII");
    }

    [Test]
    public void Case3()
    {
        var solution = new _12_IntegerToRoman();
        var result = solution.IntToRoman(1994);

        result.Should().Be("MCMXCIV");
    }

    [Test]
    public void Case4()
    {
        var solution = new _12_IntegerToRoman();
        var result = solution.IntToRoman(3888);

        result.Should().Be("MMMDCCCLXXXVIII");
    }
}
