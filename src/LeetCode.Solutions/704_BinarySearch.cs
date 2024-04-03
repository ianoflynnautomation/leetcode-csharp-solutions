
namespace LeetCode.Solutions;

/// <summary>
/// 704. Binary Search
/// https://leetcode.com/problems/binary-search/
/// 
/// Given an array of integers nums which is sorted in ascending order, and an integer target, 
/// write a function to search target in nums. 
/// If target exists, then return its index. Otherwise, return -1.
/// You must write an algorithm with O(log n) runtime complexity.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Apple)]
[Level(Level.Easy)]
public class _704_BinarySearch
{
    public int Search(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target) return i;
        }
        return -1;
    }
}