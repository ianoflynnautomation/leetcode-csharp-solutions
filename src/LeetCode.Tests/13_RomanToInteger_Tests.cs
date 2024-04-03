
namespace LeetCode.Tests;

public class _13_RomanToInteger_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _13_RomanToInteger();
        var result = solution.RomanToInt("III");

        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var solution = new _13_RomanToInteger();
        var result = solution.RomanToInt("LVIII");

        result.Should().Be(58);
    }

    [Test]
    public void Case3()
    {
        var solution = new _13_RomanToInteger();
        var result = solution.RomanToInt("MCMXCIV");

        result.Should().Be(1994);
    }

    [Test]
    public void Case4()
    {
        var solution = new _13_RomanToInteger();
        var result = solution.RomanToInt("MMMCMXCIX");

        result.Should().Be(3999);
    }

}
