
namespace LeetCode.Tests;

/// <summary>
/// 14. Longest Common Prefix
/// https://leetcode.com/problems/longest-common-prefix/
/// 
/// Write a function to find the longest common prefix string amongst an array of strings.
/// If there is no common prefix, return an empty string "".
/// </summary>

[Companies(Company.Adobe, Company.Amazon, Company.Bloomberg)]
[Level(Level.Easy)]
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
