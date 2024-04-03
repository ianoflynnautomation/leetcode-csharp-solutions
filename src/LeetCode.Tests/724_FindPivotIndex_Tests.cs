
namespace LeetCode.Tests;

public class _724_FindPivotIndex_Tests
{
    [Test]
    public void Case1()
    {
        var testData = new int[] { 1, 7, 3, 6, 5, 6 };

        var solution = new _724_FindPivotIndex();
        var result = solution.PivotIndex(testData);

        result.Should().Be(3);
    }

    [Test]
    public void Case2()
    {
        var testData = new int[] { 1, 2, 3 };

        var solution = new _724_FindPivotIndex();
        var result = solution.PivotIndex(testData);

        result.Should().Be(-1);
    }

    [Test]
    public void Case3()
    {
        var testData = new int[] { 2, 1, -1 };

        var solution = new _724_FindPivotIndex();
        var result = solution.PivotIndex(testData);

        result.Should().Be(0);
    }
    
}
