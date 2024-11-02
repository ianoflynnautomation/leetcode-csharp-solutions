namespace LeetCode.Solutions;

/// <summary>
/// 347. Top K Frequent Elements
/// https://leetcode.com/problems/top-k-frequent-elements/
/// Given an integer array nums and an integer k, return the k most frequent elements. 
/// You may return the answer in any order.

/// Example 1:
/// 
/// Input: nums = [1,1,1,2,2,3], k = 2
/// Output: [1,2]
/// Example 2:
/// 
/// Input: nums = [1], k = 1
/// Output: [1]
///  
/// Constraints:
/// 
/// 1 <= nums.length <= 105
/// -104 <= nums[i] <= 104
/// k is in the range [1, the number of unique elements in the array].
/// It is guaranteed that the answer is unique.
/// </summary>

[Level(Level.Medium)]
public class _347_TopKFrequentElements
{
    [TimeComplexity("O(n log k)")]
    [SpaceComplexity("O(n)")]
    public int[] TopKFrequent(int[] nums, int k)
    {
        var count = new Dictionary<int, int>();
        foreach (int num in nums)
        {
            if (count.ContainsKey(num)) count[num]++;
            else count[num] = 1;
        }

        List<int[]> arr = count.Select(entry => new int[] { entry.Value, entry.Key }).ToList();
        arr.Sort((a, b) => b[0].CompareTo(a[0]));

        int[] res = new int[k];
        for (int i = 0; i < k; i++)
        {
            res[i] = arr[i][1];
        }
        return res;

    }

    public int[] TopKFrequentLinq(int[] nums, int k)
    {
        int[] result = new int[k];

        var dictionary = new Dictionary<int, int>();

        // Count the frequency of each element
        foreach (int num in nums)
        {
            if (!dictionary.ContainsKey(num))
            {
                dictionary[num] = 0;
            }
            dictionary[num]++;
        }

        // Order the dictionary by value and take the top k elements
        var ordered = dictionary.OrderByDescending(x => x.Value).Take(k).ToList();

        for (int i = 0; i < ordered.Count(); i++)
        {
            result[i] = ordered[i].Key;
        }

        return result;


    }
}
