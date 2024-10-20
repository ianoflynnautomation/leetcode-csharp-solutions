using LeetCode.Solutions.NeetCode150.ArraysAndHashing;

public class ProductOfArrayExceptSelfTests
{
    [Test]
    public void Case1()
    {
        var solution = new ProductOfArrayExceptSelfSolution();
        var result = solution.ProductExceptSelf([1, 2, 3, 4]);

        result.Should().Equal([24, 12, 8, 6]);
    }

    [Test]
    public void Case2()
    {
        var solution = new ProductOfArrayExceptSelfSolution();
        var result = solution.ProductExceptSelf([-1, 1, 0, -3, 3]);

        result.Should().Equal([0, 0, 9, 0, 0]);
    }
}