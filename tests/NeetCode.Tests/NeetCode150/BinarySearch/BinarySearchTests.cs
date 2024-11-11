namespace NeetCode.Tests.NeetCode150.BinarySearch;
public class BinarySearchTests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { -1, 0, 2, 4, 6, 8 };
        var target = 4;
        var solution = new BinarySearchSolution();
        var result = solution.Search(nums, target);
        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var nums = new int[] { -1, 0, 2, 4, 6, 8 };
        var target = 3;
        var solution = new BinarySearchSolution();
        var result = solution.Search(nums, target);
        result.Should().Be(-1);
    }

}
