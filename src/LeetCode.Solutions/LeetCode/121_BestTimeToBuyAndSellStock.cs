
namespace LeetCode.Solutions;

/// <summary>
/// 121. Best Time to Buy and Sell Stock
/// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
/// 
/// You are given an array prices where prices[i] is the price of a given stock on the ith day.
/// You want to maximize your profit by choosing a single day to buy one stock and choosing a 
/// different day in the future to sell that stock.
/// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Adobe)]
[Level(Level.Easy)]
public class _121_BestTimeToBuyAndSellStock
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length == 0) return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            else
            {
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
        }
        return maxProfit;
    }
}
