
namespace LeetCode.Solutions
{
    public class _704_BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target) return i;
            }
            return -1;
        }
    }
}