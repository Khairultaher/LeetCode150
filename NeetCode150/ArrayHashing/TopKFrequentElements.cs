using NeetCode150.Configs;

namespace NeetCode150;

public class TopKFrequentElementsTest
{
    [Theory]
    [InlineData(new int[] { 1, 1, 1, 2, 2, 3 }, 2, new int[] { 1, 2 })]
    public void TopKFrequent(int[] nums, int k, int[] expected)
    {
        int[] arr = new int[k];
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }

        var pq = new PriorityQueue<int, int>();
        foreach (var key in dict.Keys)
        {
            pq.Enqueue(key, dict[key]);
            if (pq.Count > k) pq.Dequeue();
        }
        int i2 = k;
        while (pq.Count > 0)
        {
            arr[--i2] = pq.Dequeue();
        }
        var actual = arr;


        Assert.Equal(expected, actual);
    }

}