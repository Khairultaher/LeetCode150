using LeetCode150.Configs;

namespace LeetCode150;

public class GroupAnagramsTest
{
    [Theory]
    //[AutoMoqData]
    [InlineData(new object[] { new string[] { "foo", "bar", "rab", "oof" } })]
    public void GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (string s in strs)
        {
            char[] hash = new char[26];
            foreach (char c in s)
            {
                hash[c - 'a']++;
            }

            string key = new string(hash);
            if (!groups.ContainsKey(key))
            {
                groups[key] = new List<string>();
            }
            groups[key].Add(s);


            
        }
        var res = groups.Values.ToList();

        Assert.Equal(2, 2);
    }


    [Theory]
    [InlineData(new string[] { "foo" },"f")]
    //[InlineData(new object[] { new string[] { "foo" } })]
    public void StringArray_String(string[] array, string t
)
    { 
    }
}