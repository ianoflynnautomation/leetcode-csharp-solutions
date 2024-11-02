
namespace LeetCode.Tests;

public class _704_BinarySearch_Tests
{
    [Test]
    public void Case1()
    {
        var nums = new int[] { -1, 0, 3, 5, 9, 12 };

        var solution = new _704_BinarySearch();
        var result = solution.Search(nums, 9);

        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var nums = new int[] { -1, 0, 3, 5, 9, 12 };

        var solution = new _704_BinarySearch();
        var result = solution.Search(nums, 2);

        result.Should().Be(-1);
    }

}