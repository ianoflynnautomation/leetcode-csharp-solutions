namespace NeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
// You are given an array non-negative integers heights which represent an elevation map. Each value heights[i] represents the height of a bar, which has a width of 1.

// Return the maximum area of water that can be trapped between the bars.
/// </summary>
[Level(Level.Hard)]
public class TrappingRainWaterSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(1)")]
    public int Trap(int[] height)
    {

        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];
        int result = 0;

        while (left < right)
        {
            if (leftMax < rightMax)
            {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                result += leftMax - height[left];
            }
            else
            {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                result += rightMax - height[right];
            }
        }
        return result;
    }
}