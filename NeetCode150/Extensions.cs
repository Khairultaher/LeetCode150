using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150
{
    public static class Extensions
    {
        public static void AddOrCountCharToDictionary(this Dictionary<char, int> dict, char c) {
            if (dict.ContainsKey(c)) {
                dict[c]++;
            }
            else {
                dict.Add(c, 1);
            }

        }
    }
}
