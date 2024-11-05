namespace NeetCode.Tests.NeetCode150.BinarySearch;
public class FindMinimumInRotatedSortedArrayTests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { 3, 4, 5, 1, 2 };
        var solution = new FindMinimumInRotatedSortedArraySolution();
        var result = solution.FindMin(nums);
        result.Should().Be(1);
    }

    [Test]
    public void Case2()
    {
        var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        var solution = new FindMinimumInRotatedSortedArraySolution();
        var result = solution.FindMin(nums);
        result.Should().Be(0);
    }

    [Test]
    public void Case3()
    {
        var nums = new int[] { 11, 13, 15, 17 };
        var solution = new FindMinimumInRotatedSortedArraySolution();
        var result = solution.FindMin(nums);
        result.Should().Be(11);
    }

}