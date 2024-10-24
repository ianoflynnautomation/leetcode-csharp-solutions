using LeetCode.Solutions.NeetCode150.SlidingWindow;

namespace LeetCode.Solutions.NeetCode150.SlidingWindow
{
    public class BestTimeToBuyAndSellStockTests
    {
        [Test]
        public void Case1()
        {
            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            var solution = new BestTimeToBuyAndSellStockSolution();
            var result = solution.MaxProfit(prices);
            result.Should().Be(5);
        }

        [Test]
        public void Case2()
        {
            var prices = new int[] { 7, 6, 4, 3, 1 };
            var solution = new BestTimeToBuyAndSellStockSolution();
            var result = solution.MaxProfit(prices);
            result.Should().Be(0);
        }
        
    }
       
}