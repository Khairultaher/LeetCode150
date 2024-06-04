using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArrayHashing;
public class LongestConsecutiveSequenceTest
{
    [Theory]
    [InlineData(new int[] { 100, 4, 200, 1, 3, 2 }, 4)]
    public void LongestConsecutiveSequence(int[] nums, int expected)
    {
        // arrange
        var result = 0;
        // act
        if (nums.Length < 2)
            result = nums.Length;

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
        result = longest;
        // assert
        result.ShouldBe(expected);

    }
}
