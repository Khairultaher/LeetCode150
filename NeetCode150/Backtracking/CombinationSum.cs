using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeetCode150.Backtracking;
public partial class Solution
{
    IList<IList<int>> result = new List<IList<int>>();
    public void Backtrack(int index, List<int> path, int total, int[] candidates, int target) {
        if (total == target) {
            result.Add(path.ToList());
            return;
        }

        if (total > target || index >= candidates.Length) return;

        path.Add(candidates[index]);
        Backtrack(index,
                  path,
                  total + candidates[index],
                  candidates,
                  target);

        path.Remove(path.Last());

        Backtrack(index + 1,
                  path,
                  total,
                  candidates,
                  target);

    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        Backtrack(0, new List<int>(), 0, candidates, target);
        return result;
    }
}
