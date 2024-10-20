
namespace LeetCode.Solutions;

/// <summary>
/// 11. Container With Most Water
/// https://leetcode.com/problems/container-with-most-water/description/
/// 
/// You are given an integer array height of length n. 
/// There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
/// Find two lines that together with the x-axis form a container, such that the container contains the most water.
/// Return the maximum amount of water a container can store.
/// Notice that you may not slant the container.
/// </summary>

[Companies(Company.Amazon, Company.Microsoft, Company.Adobe)]
[Level(Level.Medium)]
public class _11_ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        
        int result = 0;
        int left = 0;
        int right = height.Length - 1;

        while (left < right)
        {
            int width = right - left;
            int area =  Math.Min(height[left], height[right]) * width;

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