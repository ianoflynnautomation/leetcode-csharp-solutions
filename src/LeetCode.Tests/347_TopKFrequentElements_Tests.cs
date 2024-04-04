
namespace LeetCode.Tests;

public class _347_TopKFrequentElements_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _347_TopKFrequentElements();
        var result = solution.TopKFrequent(new[] { 1, 1, 1, 2, 2, 3 }, 2);

        result.Should().BeEquivalentTo(new[] { 1, 2 });
    }

    [Test]
    public void Case2()
    {
        var solution = new _347_TopKFrequentElements();
        var result = solution.TopKFrequent(new[] { 1 }, 1);

        result.Should().BeEquivalentTo(new[] { 1 });
    }
}