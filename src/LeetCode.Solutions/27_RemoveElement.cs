
namespace LeetCode.Solutions;

/// <summary>
/// 27. Remove Element
/// https://leetcode.com/problems/remove-element/
/// 
/// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
/// The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
/// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
/// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
/// The remaining elements of nums are not important as well as the size of nums.
/// Return k.
/// </summary>

[Companies(Company.Amazon, Company.Meta, Company.Adobe)]
[Level(Level.Easy)]
    public class _27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {

            int i = 0;

            for (var j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val)
                {
                    nums[i] = nums[j];
                    i++;
                }
            }

            return i;
        }

    }
