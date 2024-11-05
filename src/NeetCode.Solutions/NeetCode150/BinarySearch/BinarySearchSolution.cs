namespace NeetCode.Solutions.NeetCode150.BinarySearch;

[Level(Level.Easy)]
public class BinarySearchSolution
{
    [TimeComplexity("O(log n)")]
    [SpaceComplexity("O(1)")]
    public int Search(int[] nums, int target)
    {

        var left = 0;
        var right = nums.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return -1;
    }

}
