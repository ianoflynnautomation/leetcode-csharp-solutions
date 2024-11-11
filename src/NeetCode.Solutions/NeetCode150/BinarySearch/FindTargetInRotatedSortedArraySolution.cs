namespace NeetCode.Solutions.NeetCode150.BinarySearch;

[Level(Level.Medium)]
public class FindTargetInRotatedSortedArraySolution
{
    [TimeComplexity("O(logn)")]
    [SpaceComplexity("O(1)")]
    public int Search(int[] nums, int target)
    {
        int l = 0, r = nums.Length - 1;

        while (l <= r)
        {
            int mid = (l + r) / 2;
            if (target == nums[mid])
            {
                return mid;
            }

            if (nums[l] <= nums[mid])
            {
                if (target > nums[mid] || target < nums[l])
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }
            else
            {
                if (target < nums[mid] || target > nums[r])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
        }
        return -1;
    }

}