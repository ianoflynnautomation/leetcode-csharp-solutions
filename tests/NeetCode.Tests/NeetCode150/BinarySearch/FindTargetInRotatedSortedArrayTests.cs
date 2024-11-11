namespace NeetCode.Tests.NeetCode150.BinarySearch;
public class FindTargetInRotatedSortedArrayTests
{
    public void Case1()
    {
        var nums = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        var target = 1;
        var solution = new FindTargetInRotatedSortedArraySolution();
        var result = solution.Search(nums, target);
        result.Should().Be(4);
    }

    public void Case2()
    {
        var nums = new int[] { 3, 5, 6, 0, 1, 2 };
        var target = 4;
        var solution = new FindTargetInRotatedSortedArraySolution();
        var result = solution.Search(nums, target);
        result.Should().Be(-1);
    }
}