
namespace LeetCode.Tests;

public class _3_LongestSubstringWithoutRepeatingCharacters_Tests
{
    [Test]
    public void Case1()
    {
        var s = "abcabcbb";

        var solution = new _3_LongestSubstringWithoutRepeatingCharacters();
        var result = solution.LengthOfLongestSubstring(s);

        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var s = "bbbbb";

        var solution = new _3_LongestSubstringWithoutRepeatingCharacters();
        var result = solution.LengthOfLongestSubstring(s);

        result.Should().Be(1);
    }

    [Test]
    public void Case3()
    {
        var s = "pwwkew";

        var solution = new _3_LongestSubstringWithoutRepeatingCharacters();
        var result = solution.LengthOfLongestSubstring(s);

        result.Should().Be(3);
    }

    [Test]
    public void Case4()
    {
        var s = "";

        var solution = new _3_LongestSubstringWithoutRepeatingCharacters();
        var result = solution.LengthOfLongestSubstring(s);

        result.Should().Be(0);
    }

}
