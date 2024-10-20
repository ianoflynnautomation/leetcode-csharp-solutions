using LeetCode.Solutions.NeetCode150.TwoPointers;

namespace LeetCode.Tests.NeetCode150.TwoPointers;

public class TwoSumIIInputArrayIsSortedTests
{
    [Test]
    public void Case1()
    {
        var numbers = new[] { 2, 7, 11, 15 };
        var target = 9;

        var solution = new TwoSumIIInputArrayIsSortedSolution();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 2);
    }

    [Test]
    public void Case2()
    {
        var numbers = new[] { 2, 3, 4 };
        var target = 6;

        var solution = new TwoSumIIInputArrayIsSortedSolution();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 3);
    }

    [Test]
    public void Case3()
    {
        var numbers = new[] { -1, 0 };
        var target = -1;

        var solution = new TwoSumIIInputArrayIsSortedSolution();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 2);
    }
}