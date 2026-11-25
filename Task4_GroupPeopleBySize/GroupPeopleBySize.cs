using System.Collections.Generic;

public class Solution
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes)
    {
        var result = new List<IList<int>>();
        var groups = new Dictionary<int, List<int>>();

        for (int i = 0; i < groupSizes.Length; i++)
        {
            int size = groupSizes[i];

            if (!groups.ContainsKey(size))
            {
                groups[size] = new List<int>();
            }

            groups[size].Add(i);

            if (groups[size].Count == size)
            {
                result.Add(groups[size]);
                groups[size] = new List<int>();
            }
        }

        return result;
    }
}