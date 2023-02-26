namespace LeetCode.Solutions;

public class _1480_RunningSumof1dArray
{
    public int[] RunningSum(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    }

}
