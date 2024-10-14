using LeetCode.Solutions.NeetCode150.ArraysAndHashing;

namespace LeetCode.Tests.NeetCode150.ArraysAndHashing;

public class TwoIntegerSumTests
{
    [Test]
    public void Case1()
    {
        var solution = new TwoIntegerSumSolution();
        var result = solution.TwoSum([2, 7, 11, 15], 9);

        result.Should().BeEquivalentTo([0, 1]);
    }

    [Test]
    public void Case2()
    {
        var solution = new TwoIntegerSumSolution();
        var result = solution.TwoSum([3, 2, 4], 6);

        result.Should().BeEquivalentTo([2, 1]);
    }

    [Test]
    public void Case3()
    {
        var solution = new TwoIntegerSumSolution();
        var result = solution.TwoSum([3, 3], 6);

        result.Should().BeEquivalentTo([1, 0]);
    }

    [Test]
    public void Case4()
    {
        var solution = new TwoIntegerSumSolution();
        var result = solution.TwoSum([1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1], 11);

        result.Should().BeEquivalentTo([5,11]);
    }
}