namespace LeetCode.Tests;

public class _1189_MaximumNumberOfBalloons_Tests
{
    [Test]
    public void Case1()
    {
        var solution = new _1189_MaximumNumberOfBalloons();
        var result = solution.MaxNumberOfBalloons("nlaebolko");

        Assert.AreEqual(1, result);
    }

    [Test]
    public void Case2()
    {
        var solution = new _1189_MaximumNumberOfBalloons();
        var result = solution.MaxNumberOfBalloons("loonbalxballpoon");

        Assert.AreEqual(2, result);
    }

    [Test]
    public void Case3()
    {
        var solution = new _1189_MaximumNumberOfBalloons();
        var result = solution.MaxNumberOfBalloons("leetcode");

        Assert.AreEqual(0, result);
    }
}