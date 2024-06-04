using Shouldly;

namespace NeetCode150.SlidingWindow;
public partial class Solution
{
    [Theory]
    [InlineData("abcabcbb", 3)]
    public void LengthOfLongestSubstring(string s, int expected) {

        int leftPointer = 0, rightPointer = 0, maxLength = 0;
        HashSet<int> chars = new HashSet<int>();

        while (rightPointer < s.Length) {
            char currChar = s[rightPointer];
            if (chars.Contains(currChar)) { // Move left pointer until all duplicate chars removed
                chars.Remove(s[leftPointer]);
                leftPointer++;
            }
            else {
                chars.Add(currChar);
                maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
                rightPointer++;
            }
        }

        maxLength.ShouldBe(expected);
    }
}
