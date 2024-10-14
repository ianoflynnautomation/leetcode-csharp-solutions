namespace LeetCode.Tests;

public class _271_StringEncodeAndDecode_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _271_StringEncodeAndDecode();
        var result = solution.Encode(new List<string> { "leet", "code", "love", "you" });
        result.Should().Be("4#leet4#code4#love3#you");
    }

    [Test]
    public void Case2()
    {
        var solution = new _271_StringEncodeAndDecode();
        var result = solution.Decode("4#neet4#code4#love3#you");
        result.Should().Equal(new List<string> { "neet", "code", "love", "you" });
    }

}
