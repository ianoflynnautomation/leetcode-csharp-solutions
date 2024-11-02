namespace NeetCode.Tests.NeetCode150.ArraysAndHashing;

public class TopKFrequentElementsTests
{
    [Test]
    public void Case1()
    {
        var solution = new TopKFrequentElementsSolution();
        var result = solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2);

        result.Should().BeEquivalentTo([1, 2]);
    }

    [Test]
    public void Case2()
    {
        var solution = new TopKFrequentElementsSolution();
        var result = solution.TopKFrequent([1], 1);

        result.Should().BeEquivalentTo([1]);
    }
}