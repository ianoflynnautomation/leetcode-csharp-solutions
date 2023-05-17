
namespace LeetCode.Solutions
{
    public class _11_ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {

            int left = 0;
            int right = height.Length - 1;
            int result = 0;

            while (left < right)
            {
                int width = right - left;
                result = Math.Max(result, Math.Min(height[left], height[right]) * width);
                if (height[left] <= height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }
            return result;
        }
    }
}