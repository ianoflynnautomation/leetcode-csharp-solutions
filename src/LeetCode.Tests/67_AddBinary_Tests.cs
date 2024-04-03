
namespace LeetCode.Tests;

public class _67_AddBinary_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _67_AddBinary();
        var result = solution.AddBinary("11", "1");

        result.Should().Be("100");
    }

    [Test]
    public void Case2()
    {
        var solution = new _67_AddBinary();
        var result = solution.AddBinary("1010", "1011");

        result.Should().Be("10101");
    }
    
}
