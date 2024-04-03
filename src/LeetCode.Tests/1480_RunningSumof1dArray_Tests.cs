
namespace LeetCode.Tests;
public class _1480_RunningSumof1dArray_Tests
{
    [Test]
    public void Case1()
    {
        var testData = new int[] { 1, 2, 3, 4 };

        var solution = new _1480_RunningSumof1dArray();
        var result = solution.RunningSum(testData);

        var expectedResult = new int[] { 1, 3, 6, 10 };
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var testData = new int[] { 1, 1, 1, 1, 1 };

        var solution = new _1480_RunningSumof1dArray();
        var result = solution.RunningSum(testData);

        var expectedResult = new int[] { 1, 2, 3, 4, 5 };
        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var testData = new int[] { 3, 1, 2, 10, 1 };

        var solution = new _1480_RunningSumof1dArray();
        var result = solution.RunningSum(testData);

        var expectedResult = new int[] { 3, 4, 6, 16, 17 };
        result.Should().BeEquivalentTo(expectedResult);
    }
    
}
