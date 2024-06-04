using Shouldly;

namespace NeetCode150.SlidingWindow;
public partial class Solution
{
    [Theory]
    [InlineData(new int[] { 3,4,5,1,2 }, 1)]
    public void FindMinimumInRotatedSortedArray(int[] nums, int expected)
    {
        int res = nums[0];
        int l = 0, r = nums.Length - 1;
        while (l <= r) {
            if (nums[l] < nums[r]) { 
                res = Math.Min(res, nums[l]);
                break;
            }

            int m = (l + r) / 2;
            res = Math.Min(res, m);
            if (nums[m] >= nums[l]) {
                l = m + 1;
            }
            else { 
                r = m - 1;
            }
        }
        expected.ShouldBe(res);
    }
}