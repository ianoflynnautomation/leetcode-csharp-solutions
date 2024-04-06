namespace LeetCode.Tests;

public class _128_LongestConsecutiveSequence_Tests
{

    [Test]
    public void Case1()
    {
        var nums = new[] { 100, 4, 200, 1, 3, 2 };

        var solution = new _128_LongestConsecutiveSequence();
        var result = solution.LongestConsecutive(nums);

        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var nums = new[] { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1 };

        var solution = new _128_LongestConsecutiveSequence();
        var result = solution.LongestConsecutive(nums);

        result.Should().Be(9);
    }

}