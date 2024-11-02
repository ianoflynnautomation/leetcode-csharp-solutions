namespace NeetCode.Tests.NeetCode150.SlidingWindow;

public class LongestRepeatingSubstringWithReplacementTests
{
    [Test]
    public void Case1()
    {
        var s = "ABAB";
        var k = 2;
        var solution = new LongestRepeatingSubstringWithReplacementSolution();
        var result = solution.CharacterReplacement(s, k);
        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var s = "AABABBA";
        var k = 1;
        var solution = new LongestRepeatingSubstringWithReplacementSolution();
        var result = solution.CharacterReplacement(s, k);
        result.Should().Be(4);
    }
}