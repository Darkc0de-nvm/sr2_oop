using System.Collections.Generic;

public class Solution
{
    public int MaxDistinct(string s)
    {
        return new HashSet<char>(s).Count;
    }
}