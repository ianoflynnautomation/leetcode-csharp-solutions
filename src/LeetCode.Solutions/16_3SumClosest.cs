
namespace LeetCode.Solutions
{
    public class _16_3SumClosest
    {
        [TimeComplexity(" O(n^2)")]
        [SpaceComplexity("O(1)")]
        public int ThreeSumClosest(int[] nums, int target)
        {

            int closestSum = nums[0] + nums[1] + nums[2];
            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                int low = i + 1;
                int high = nums.Length - 1;

                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum == target) return sum;

                    if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                        closestSum = sum;

                    if (sum < target) low++;
                    else high--;
                }
            }
            return closestSum;
        }
    }
}