using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode150.ArrayHashing;
public class ValidPalindromeTest
{
    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    public void ValidPalindrome(string s, bool expected)
    {
        // arrange
        var result = true;

        // act
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            else if (!char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            else
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    result = false;
                }
                left++;
                right--;
            }
        }
        result = true;
        // assert
        result.ShouldBe(expected);

    }
}
