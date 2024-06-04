using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.SlidingWindow;

public partial class Solution
{

    [Theory]
    [InlineData("ADOBECODEBANC", "ABC", "BANC")]
    public void MinWindow(string s, string t, string expected) {
        string actualres = "";
        if (string.IsNullOrEmpty(t))
            actualres = string.Empty;

        var countT = new Dictionary<char, int>();
        var window = new Dictionary<char, int>();

        foreach (var c in t) {
            AddCharToDictionary(c, countT);
        }

        var have = 0;
        var need = countT.Count;
        var left = 0;
        var res = new[] { -1, -1 };
        var resultLength = int.MaxValue;
        for (var right = 0; right < s.Length; right++) {
            var c = s[right];
            AddCharToDictionary(c, window);

            if (countT.ContainsKey(c) && window[c] == countT[c]) 
                have++;

            while (have == need) {
                // update our result
                var windowSize = right - left + 1;
                if (windowSize < resultLength) {
                    res = new[] { left, right };
                    resultLength = windowSize;
                }

                // pop from the left of our window
                window[s[left]]--;
                if (countT.ContainsKey(s[left]) && window[s[left]] < countT[s[left]]) {
                    have--;
                }

                left++;
            }
        }

        actualres = resultLength == int.MaxValue
           ? string.Empty
           : s.Substring(res[0], res[1] - res[0] + 1);

        actualres.ShouldBe(expected);
    }

    private void AddCharToDictionary(char c, IDictionary<char, int> dict) {
        if (dict.ContainsKey(c))
            dict[c]++;
        else
            dict.Add(c, 1);
    }
}

