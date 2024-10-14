using LeetCode.Solutions.NeetCode150.ArraysAndHashing;

namespace LeetCode.Tests.NeetCode150.ArraysAndHashing;

public class DuplicateIntegerTests
{
    [Test]
    public void Case1()
    {
        var solution = new DuplicateIntegerSolution();
        var result = solution.HasDuplicate([1, 2, 3, 1]);
        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new DuplicateIntegerSolution();
        var result = solution.HasDuplicate([1, 2, 3, 4]);
        result.Should().BeFalse();
    }

}
