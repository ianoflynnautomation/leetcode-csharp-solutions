
namespace LeetCode.Tests;

public class _7_ReverseInteger_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _7_ReverseInteger();
        var result = solution.Reverse(123);

        result.Should().Be(321);
    }

    [Test]
    public void Case2()
    {
        var solution = new _7_ReverseInteger();
        var result = solution.Reverse(-123);

        result.Should().Be(-321);
    }

    [Test]
    public void Case3()
    {
        var solution = new _7_ReverseInteger();
        var result = solution.Reverse(120);

        result.Should().Be(21);
    }

}