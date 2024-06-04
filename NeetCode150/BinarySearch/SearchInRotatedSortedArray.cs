using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.BinarySearch;
public partial class Solution
{
    [Theory]
    [InlineData(new int[] { 4,5,6,7,0,1,2 }, 0, 4)]
    [InlineData(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
    public void SearchInRotatedSortedArray(int[] nums, int target, int expected) {
        int res = -1;
        int l = 0, r = nums.Length - 1;
        while (l <= r) {
            int mid = (l + r) / 2;
            if (target == nums[mid]) {
                res = mid;
            }

            // left sorted portion 
            if (nums[l] <= nums[mid]) {
                if (target > nums[mid] || target < nums[l]) {
                    l = mid + 1;
                }
                else {
                    r = mid - 1;
                }
            }
            // right sorted portion
            else { 
                if (target < nums[mid] || target > nums[r]) {
                    r = mid - 1;
                }
                else {
                    l = mid + 1;
                }
            }
        }
        expected.ShouldBe(res);
    }
}


