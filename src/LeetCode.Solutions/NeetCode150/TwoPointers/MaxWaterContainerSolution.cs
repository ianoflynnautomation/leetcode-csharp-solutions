
namespace LeetCode.Solutions.NeetCode150.TwoPointers;

/// <summary>
// You are given an integer array heights where heights[i] represents the height of the ith bar.
// You may choose any two bars to form a container. Return the maximum amount of water a container can store.
/// </summary>

[Companies(Company.Amazon, Company.Microsoft, Company.Adobe)]
[Level(Level.Medium)]
public class MaxWaterContainerSolution
{
    public int MaxArea(int[] height)
    {
        int result = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int area = Math.Min(height[left], height[right]) * width;

            result = Math.Max(result, area);

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