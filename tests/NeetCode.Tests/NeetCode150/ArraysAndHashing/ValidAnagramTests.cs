
namespace NeetCode.Tests.NeetCode150.ArraysAndHashing;

public class ValidAnagramTests
{
    [Test]
    public void Case1()
    {
        var solution = new ValidAnagramSolution();
        var result = solution.IsAnagram("anagram", "nagaram");
        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new ValidAnagramSolution();
        var result = solution.IsAnagram("rat", "car");
        result.Should().BeFalse();
    }

}