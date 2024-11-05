namespace NeetCode.Solutions.NeetCode150.BinarySearch;

[Level(Level.Medium)]
public class FindMinimumInRotatedSortedArraySolution
{
    [TimeComplexity("O(log n)")]
    [SpaceComplexity("O(1)]")]
    public int FindMin(int[] nums) {
        int left = 0;
        int right = nums.Length - 1;
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            
            // If the mid element is greater than the rightmost element,
            // the minimum is in the right half.
            if (nums[mid] > nums[right]) {
                left = mid + 1;
            } else {
                // Otherwise, the minimum is in the left half, including mid.
                right = mid;
            }
        }
        
        // After the loop, left == right, pointing to the minimum element.
        return nums[left];
    }
}