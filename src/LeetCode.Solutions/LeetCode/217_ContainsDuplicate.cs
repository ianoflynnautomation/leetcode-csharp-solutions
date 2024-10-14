namespace LeetCode.Solutions;

/// <summary>
/// https://leetcode.com/problems/contains-duplicate/
/// 
/// Given an integer array nums, return true if any value appears at least twice in the array, 
/// and return false if every element is distinct.
/// 
/// Example 1:
/// Input: nums = [1,2,3,1]
/// Output: true
///
/// Example 2:
/// Input: nums = [1,2,3,4]
/// Output: false

/// Example 3:
/// Input: nums = [1,1,1,3,3,4,3,2,4,2]
/// Output: true
/// </summary>

[Level(Level.Easy)]
public class _217_ContainsDuplicate
{
    public bool ContainsDuplicate(int[] nums)
    {
        var uniqueNumbers = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (uniqueNumbers.Contains(nums[i]))
            {
                return true;
            }     
                
            uniqueNumbers.Add(nums[i]);
        }

        return false;
    }

}
