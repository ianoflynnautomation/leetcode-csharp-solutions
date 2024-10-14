
namespace LeetCode.Tests;

public class _217_ContainsDuplicate_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _217_ContainsDuplicate();
        var result = solution.ContainsDuplicate(new[] { 1, 2, 3, 1 });
        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new _217_ContainsDuplicate();
        var result = solution.ContainsDuplicate(new[] { 1, 2, 3, 4 });
        result.Should().BeFalse();
    }

    [Test]
    public void Case3()
    {
        var solution = new _217_ContainsDuplicate();
        var result = solution.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 });
        result.Should().BeTrue();
    }
}
