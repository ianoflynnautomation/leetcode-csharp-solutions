namespace LeetCode.Tests;

public class _167_TwoSumIIInputArrayIsSorted_Tests
{
    [Test]
    public void Case1()
    {
        var numbers = new[] { 2, 7, 11, 15 };
        var target = 9;

        var solution = new _167_TwoSumIIInputArrayIsSorted();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 2);
    }

    [Test]
    public void Case2()
    {
        var numbers = new[] { 2, 3, 4 };
        var target = 6;

        var solution = new _167_TwoSumIIInputArrayIsSorted();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 3);
    }

    [Test]
    public void Case3()
    {
        var numbers = new[] { -1, 0 };
        var target = -1;

        var solution = new _167_TwoSumIIInputArrayIsSorted();
        var result = solution.TwoSum(numbers, target);

        result.Should().Equal(1, 2);
    }
}