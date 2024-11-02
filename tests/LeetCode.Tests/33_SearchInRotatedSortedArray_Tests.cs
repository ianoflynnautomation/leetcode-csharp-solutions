namespace LeetCode.Tests;
public class _33_SearchInRotatedSortedArray_Tests
{
    [Test]
    public void Case1()
    {
        var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };
        var target = 0;

        var solution = new _33_SearchInRotatedSortedArray();
        var result = solution.Search(nums, target);

        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };
        var target = 3;

        var solution = new _33_SearchInRotatedSortedArray();
        var result = solution.Search(nums, target);

        result.Should().Be(-1);
    }

    [Test]
    public void Case3()
    {
        var nums = new[] { 1 };
        var target = 0;

        var solution = new _33_SearchInRotatedSortedArray();
        var result = solution.Search(nums, target);

        result.Should().Be(-1);
    }
}