public class Solution
{
    public int TotalWaviness(int num1, int num2)
    {
        int total = 0;

        for (int num = Math.Max(100, num1); num <= num2; num++)
        {
            string s = num.ToString();
            for (int i = 1; i < s.Length - 1; i++)
            {
                if ((s[i] > s[i - 1] && s[i] > s[i + 1]) ||
                    (s[i] < s[i - 1] && s[i] < s[i + 1]))
                {
                    total++;
                }
            }
        }

        return total;
    }
}