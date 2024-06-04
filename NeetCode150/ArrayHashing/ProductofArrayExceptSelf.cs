using NeetCode150.Configs;

namespace NeetCode150;

public class ProductofArrayExceptSelfTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    public void ProductOfArrayExceptSelf(int[] nums, int[] expected)
    {
        int prefix = 1, postfix = 1;
        int[] res = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = prefix;
            prefix *= nums[i];
        }

        for (int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= postfix;
            postfix *= nums[i];
        }

        var actual = res;
        Assert.Equal(expected, actual);
    }

}