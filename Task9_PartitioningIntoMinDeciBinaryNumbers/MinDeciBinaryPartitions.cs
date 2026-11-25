public class Solution
{
    public int MinPartitions(string n)
    {
        char maxDigit = '0';

        foreach (char c in n)
        {
            if (c > maxDigit)
            {
                maxDigit = c;
                if (maxDigit == '9') return 9;
            }
        }

        return maxDigit - '0';
    }
}