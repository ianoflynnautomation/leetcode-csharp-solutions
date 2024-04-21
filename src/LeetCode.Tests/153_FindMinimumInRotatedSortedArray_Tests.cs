namespace LeetCode.Tests;

public class _153_FindMinimumInRotatedSortedArray_Tests
{
    [Test]
    public void Case1()
    {
        var nums = new[] { 3, 4, 5, 1, 2 };

        var solution = new _153_FindMinimumInRotatedSortedArray();
        var result = solution.FindMin(nums);

        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };

        var solution = new _153_FindMinimumInRotatedSortedArray();
        var result = solution.FindMin(nums);

        result.Should().Be(0);
    }

    [Test]
    public void Case3()
    {
        var nums = new[] { 11, 13, 15, 17 };

        var solution = new _153_FindMinimumInRotatedSortedArray();
        var result = solution.FindMin(nums);

        result.Should().Be(11);
    }

}