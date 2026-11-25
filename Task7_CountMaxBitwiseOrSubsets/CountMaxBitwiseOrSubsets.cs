public class Solution
{
    public int CountMaxOrSubsets(int[] nums)
    {
        int maxOr = 0;
        foreach (int x in nums)
        {
            maxOr |= x;
        }

        int Dfs(int index, int currentOr)
        {
            if (index == nums.Length)
            {
                return currentOr == maxOr ? 1 : 0;
            }

            return Dfs(index + 1, currentOr | nums[index]) + Dfs(index + 1, currentOr);
        }

        return Dfs(0, 0);
    }
}