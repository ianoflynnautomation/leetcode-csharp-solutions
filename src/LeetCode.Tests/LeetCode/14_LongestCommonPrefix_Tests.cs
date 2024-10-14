
namespace LeetCode.Tests;

public class _14_LongestCommonPrefix_Tests
{

    [Test]
    public void Case1()
    {
        var strs = new string[] { "flower", "flow", "flight" };

        var solution = new _14_LongestCommonPrefix();
        var result = solution.LongestCommonPrefix(strs);

        result.Should().Be("fl");
    }

    [Test]
    public void Case2()
    {
        var strs = new string[] { "dog", "racecar", "car" };

        var solution = new _14_LongestCommonPrefix();
        var result = solution.LongestCommonPrefix(strs);

        result.Should().Be("");
    }

}
