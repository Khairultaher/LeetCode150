using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode150.SlidingWindow;
public partial class Solution
{
    [Theory]
    [InlineData("AABABBA", 1, 4)]
    public void CharacterReplacement(string s, int k, int expected) {
        int left = 0, maxLength = 0;
        int mostFrequentLetterCount = 0; // Count of most frequent letter in the window
        int[] charCounts = new int[26]; // Counts per letter

        for (int right = 0; right < s.Length; right++) {
            charCounts[s[right] - 'A']++;
            mostFrequentLetterCount = Math.Max(mostFrequentLetterCount, charCounts[s[right] - 'A']);

            int lettersToChange = (right - left + 1) - mostFrequentLetterCount;
            if (lettersToChange > k) { // Window is invalid, decrease char count and move left pointer
                charCounts[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, (right - left + 1));
        }
        maxLength.ShouldBe(expected);
    }
}
