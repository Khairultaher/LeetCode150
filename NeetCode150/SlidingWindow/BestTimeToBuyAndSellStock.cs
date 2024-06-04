using Shouldly;

namespace NeetCode150.SlidingWindow;
public partial class Solution
{
    [Theory]
    [InlineData(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    public void MaxProfit(int[] prices, int expected)
    {
        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            int currPrice = prices[i];
            minPrice = Math.Min(minPrice, currPrice);
            maxProfit = Math.Max(maxProfit, currPrice - minPrice);
        }
        expected.ShouldBe(maxProfit);
    }
}