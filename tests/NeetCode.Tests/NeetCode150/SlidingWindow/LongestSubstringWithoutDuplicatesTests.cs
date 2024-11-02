
namespace NeetCode.Tests.NeetCode150.SlidingWindow;

public class LongestSubstringWithoutDuplicatesTests
{

    [Test]
    public void Case1()
    {
        var s = "abcabcbb";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var s = "bbbbb";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(1);
    }

    [Test]
    public void Case3()
    {
        var s = "pwwkew";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(3);
    }

    [Test]
    public void Case4()
    {
        var s = "";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(0);
    }

    [Test]
    public void Case5()
    {
        var s = " ";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(1);
    }

    [Test]
    public void Case6()
    {
        var s = "au";
        var solution = new LongestSubstringWithoutDuplicatesSolution();
        var result = solution.LengthOfLongestSubstring(s);
        result.Should().Be(2);
    }
}