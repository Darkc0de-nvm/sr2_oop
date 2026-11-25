using System.Collections.Generic;

public class Solution
{
    public IList<string> ValidStrings(int n)
    {
        var result = new List<string> { "0", "1" };

        for (int len = 2; len <= n; len++)
        {
            var next = new List<string>();
            foreach (string s in result)
            {
                next.Add(s + "1");
                if (s[^1] == '1')
                {
                    next.Add(s + "0");
                }
            }
            result = next;
        }

        return result;
    }
}