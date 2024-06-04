using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.Stack;
public class Solution
{
    [Theory]
    [InlineData("()[]{}", true)]
    public void IsValid(string s, bool expected) {
        bool res = false;
        var stack = new Stack<char>();
        var pairs = new Dictionary<char, char>() {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{'
        };

        foreach (char c in s) {
            if (!pairs.ContainsKey(c)) {
                stack.Push(c);
            }
            else if (stack.Count == 0 || stack.Pop() != pairs[c]) {
                res = false;
            }
        }

        res = stack.Count == 0;

        res.ShouldBe(expected);
    }
}
