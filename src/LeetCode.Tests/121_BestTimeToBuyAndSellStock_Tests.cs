
namespace LeetCode.Tests;
public class _121_BestTimeToBuyAndSellStock_Tests
{
    [Test]
    public void Case1()
    {
        var prices = new[] { 7, 1, 5, 3, 6, 4 };

        var soultion = new _121_BestTimeToBuyAndSellStock();
        var result = soultion.MaxProfit(prices);

        result.Should().Be(5);
    }

    [Test]
    public void Case2()
    {
        var prices = new[] { 7, 6, 4, 3, 1 };

        var soultion = new _121_BestTimeToBuyAndSellStock();
        var result = soultion.MaxProfit(prices);

        result.Should().Be(0);
    }
    
}