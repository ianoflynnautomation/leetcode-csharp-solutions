namespace LeetCode.Solutions;

/// <summary>
/// 84. Largest Rectangle in Histogram
/// https://leetcode.com/problems/largest-rectangle-in-histogram/
/// Given an array of integers heights representing the histogram's bar height where the width of each bar is 1,
/// return the area of the largest rectangle in the histogram.
/// </summary>

[Level(Level.Hard)]
public class _84_LargestRectangleInHistogram
{
    public int LargestRectangleArea(int[] heights)
    {

        var stack = new Stack<int>();

        int max = 0;

        for (int i = 0; i <= heights.Length; i++)
        {

            var height = i < heights.Length ? heights[i] : 0;

            while (stack.Count != 0 && heights[stack.Peek()] > height)
            {
                var currentHeight = heights[stack.Pop()];
                var previousIndex = stack.Count == 0 ? -1 : stack.Peek();

                max = Math.Max(max, currentHeight * (i - 1 - previousIndex));
            }

            stack.Push(i);
        }

        return max;
    }
}