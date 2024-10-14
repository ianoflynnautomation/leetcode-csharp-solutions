namespace LeetCode.Tests;

public class _238_ProductOfArrayExceptSelf_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _238_ProductOfArrayExceptSelf();
        var result = solution.ProductExceptSelf([1, 2, 3, 4]);

        result.Should().Equal([24, 12, 8, 6]);
    }

    [Test]
    public void Case2()
    {
        var solution = new _238_ProductOfArrayExceptSelf();
        var result = solution.ProductExceptSelf([-1, 1, 0, -3, 3]);

        result.Should().Equal([0, 0, 9, 0, 0]);
    }
}