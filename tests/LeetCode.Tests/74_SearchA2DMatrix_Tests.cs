namespace LeetCode.Tests;

public class _74_SearchA2DMatrix_Tests
{
    [Test]
    public void Case1()
    {
        var matrix = new int[][]
        {
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        };

        var solution = new _74_SearchA2DMatrix();
        var result = solution.SearchMatrix(matrix, 3);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var matrix = new int[][]
        {
            [1, 3, 5, 7],
            [10, 11, 16, 20],
            [23, 30, 34, 60]
        };

        var solution = new _74_SearchA2DMatrix();
        var result = solution.SearchMatrix(matrix, 13);

        result.Should().BeFalse();
    }
}