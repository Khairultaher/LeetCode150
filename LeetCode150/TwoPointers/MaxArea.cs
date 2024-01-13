using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode150.TwoPointers;
public class Solution
{
    [Theory]
    [InlineData(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
    public void MaxArea(int[] height, int expected)
    {
        // arrange
        int res = 0, area = 0, left = 0, right = height.Length - 1;

        // act
        while (left < right)
        {

            area = (Math.Min(height[left], height[right])) * (right - left);
            res = Math.Max(area, res);

            if (height[left] < height[right]){
                left++;
            }
            else{
                right--;
            }

        }

        // assert (using Shouldly)
        res.ShouldBe(expected);
    }
}

