namespace LeetCode.Tests;

public class _875_KokoEatingBananas_Tests
{
    [Test]
    public void Case1()
    {
        var piles = new[] { 3, 6, 7, 11 };

        // arange
        var solution = new _875_KokoEatingBananas();
        // act
        var result = solution.MinEatingSpeed(piles, 8);
        // assert
        result.Should().Be(4);
    }

    [Test]
    public void Case2()
    {
        var piles = new[] { 30, 11, 23, 4, 20 };

        // arange
        var solution = new _875_KokoEatingBananas();
        // act
        var result = solution.MinEatingSpeed(piles, 5);
        // assert
        result.Should().Be(30);
    }

    [Test]
    public void Case3()
    {
        var piles = new[] { 30, 11, 23, 4, 20 };

        // arange
        var solution = new _875_KokoEatingBananas();
        // act
        var result = solution.MinEatingSpeed(piles, 6);
        // assert
        result.Should().Be(23);
    }
}