namespace LeetCode.Tests;

public class _242_ValidAnagram_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _242_ValidAnagram();

        var result = solution.IsAnagram("anagram", "nagaram");

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {
        var solution = new _242_ValidAnagram();

        var result = solution.IsAnagram("rat", "car");

        result.Should().BeFalse();
    }

}