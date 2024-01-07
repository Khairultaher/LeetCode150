using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode150.ArrayHashing;
public class LongestConsecutiveSequenceTest
{
    [Theory]
    [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 9)]
    public void LongestConsecutiveSequence(int[] nums, int expected)
    {

        var res = 0;
        if (nums.Length < 2)
            res = nums.Length;

        var set = new HashSet<int>(nums);
        var longest = 0;
        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                var length = 0;
                while (set.Contains(n + length))
                {
                    length++;
                    longest = Math.Max(longest, length);
                }
            }
        }

        res = longest;
        Assert.Equal(expected, res);
    }
}
