
namespace NeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
/// Given an integer array nums, return true if any value appears more than once in the array, 
/// otherwise return false.
///
/// Example 1:
/// Input: nums = [1, 2, 3, 3]
/// Output: true
/// Example 2:
/// Input: nums = [1, 2, 3, 4]
/// Output: false
/// </summary>
[Level(Level.Easy)]
public class DuplicateIntegerSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public bool HasDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (hashSet.Contains(num)) return true;
            hashSet.Add(num);
        }
        return false;
    }

}