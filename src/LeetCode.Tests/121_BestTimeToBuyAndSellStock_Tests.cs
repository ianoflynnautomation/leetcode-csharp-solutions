
namespace LeetCode.Tests
{
    /// <summary>
    /// 121. Best Time to Buy and Sell Stock
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    /// 
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    /// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
    /// </summary>

    [Companies(Company.Amazon, Company.Apple, Company.Adobe)]
    [Level(Level.Easy)]
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
}