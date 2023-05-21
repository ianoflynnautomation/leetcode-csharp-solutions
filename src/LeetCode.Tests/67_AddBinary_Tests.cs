
namespace LeetCode.Tests;

/// <summary>
/// 67. Add Binary
/// https://leetcode.com/problems/add-binary/
/// 
/// Given two binary strings a and b, return their sum as a binary string.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Bloomberg)]
[Level(Level.Easy)]
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
