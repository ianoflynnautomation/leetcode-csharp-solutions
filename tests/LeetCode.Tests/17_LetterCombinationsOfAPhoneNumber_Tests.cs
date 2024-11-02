
namespace LeetCode.Tests;

public class _17_LetterCombinationsOfAPhoneNumber_Tests
{
    [Test]
    public void Case1()
    {
        var digits = "23";

        var solution = new _17_LetterCombinationsOfAPhoneNumber();
        var result = solution.LetterCombinations(digits);

        var expectedResult = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case2()
    {
        var digits = "";

        var solution = new _17_LetterCombinationsOfAPhoneNumber();
        var result = solution.LetterCombinations(digits);

        var expectedResult = new List<string>() { };

        result.Should().BeEquivalentTo(expectedResult);
    }

    [Test]
    public void Case3()
    {
        var digits = "2";

        var solution = new _17_LetterCombinationsOfAPhoneNumber();
        var result = solution.LetterCombinations(digits);

        var expectedResult = new List<string>() { "a", "b", "c" };

        result.Should().BeEquivalentTo(expectedResult);
    }
    
}