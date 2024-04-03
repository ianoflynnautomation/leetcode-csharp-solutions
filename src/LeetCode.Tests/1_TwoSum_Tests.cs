
namespace LeetCode.Tests;

public class _1_TwoSum_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _1_TwoSum();
        var result = solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

        result.Should().BeEquivalentTo(new int[] { 0, 1 });
    }

    [Test]
    public void Case2()
    {
        var solution = new _1_TwoSum();
        var result = solution.TwoSum(new int[] { 3, 2, 4 }, 6);

        result.Should().BeEquivalentTo(new int[] { 2, 1 });
    }

    [Test]
    public void Case3()
    {
        var solution = new _1_TwoSum();
        var result = solution.TwoSum(new int[] { 3, 3 }, 6);

        result.Should().BeEquivalentTo(new int[] { 1, 0 });
    }

}