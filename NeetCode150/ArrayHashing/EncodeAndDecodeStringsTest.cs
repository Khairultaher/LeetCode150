using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.ArrayHashing;

public class EncodeAndDecodeStringsTest
{
    [Theory]
    [InlineData(new string[] { "foo", "bar", "car"} ,  new string[] { "foo", "bar", "car" })]
    public void EncodeAndDecodeStrings(string[] inputs, string[] expected)
    {
        var encoded = Encode(inputs);
        var decoded = Decode(encoded);

        Assert.Equal(expected, decoded);
    }


    public string Encode(IList<string> strs)
    {
        var select = strs.Select(s => $"{s.Length}#{s}");
        var selectMany = strs.SelectMany(s => $"{s.Length}#{s}");

        return string.Concat(selectMany);
    }

    public IList<string> Decode(string s)
    {
        var res = new List<string>();

        var i = 0;
        while (i < s.Length)
        {
            var j = i;
            while (s[j] != '#')
            {
                ++j;
            }

            int.TryParse(s.Substring(i, j - i), out var len);
            j++;
            res.Add(s.Substring(j, len));
            i = j + len;
        }

        return res;
    }
}
