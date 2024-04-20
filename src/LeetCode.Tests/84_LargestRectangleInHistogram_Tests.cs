namespace LeetCode.Tests;
public class _84_LargestRectangleInHistogram_Tests
{

    [Test]
    public void Case1()
    {
        var testData = new int[] { 2, 1, 5, 6, 2, 3 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(10);
    }

    [Test]
    public void Case2()
    {
        var testData = new int[] { 2, 4 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(4);
    }

    [Test]
    public void Case3()
    {
        var testData = new int[] { 2, 1, 2 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(3);
    }

    [Test]
    public void Case4()
    {
        var testData = new int[] { 1, 2, 3, 4, 5 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(9);
    }

    [Test]
    public void Case5()
    {
        var testData = new int[] { 5, 4, 3, 2, 1 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(9);
    }

    [Test]
    public void Case6()
    {
        var testData = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var solution = new _84_LargestRectangleInHistogram();
        var result = solution.LargestRectangleArea(testData);

        result.Should().Be(30);
    }

}