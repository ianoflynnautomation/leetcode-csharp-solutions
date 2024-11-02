namespace NeetCode.Tests.NeetCode150.SlidingWindow;

public class PermutationInStringTests
{

    [Test]
    public void Case1()
    {
        var s1 = "abc";
        var s2 = "lecabee";
        var solution = new PermutationInStringSolution();
        var result = solution.CheckInclusion(s1, s2);
        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var s1 = "abc";
        var s2 = "lecaabee";
        var solution = new PermutationInStringSolution();
        var result = solution.CheckInclusion(s1, s2);
        result.Should().BeFalse();
    }
}