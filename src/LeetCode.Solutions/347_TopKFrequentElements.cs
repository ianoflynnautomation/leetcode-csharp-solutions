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

        // Create a min heap based on the frequencies
        var minHeap = new SortedSet<KeyValuePair<int, int>>(
            Comparer<KeyValuePair<int, int>>.Create((a, b) =>
            {
                if (a.Value == b.Value)
                {
                    return a.Key.CompareTo(b.Key);
                }
                return a.Value.CompareTo(b.Value);
            })
        );

        // Add elements to the heap until it contains k elements
        foreach (var kvp in dictionary)
        {
            minHeap.Add(kvp);
            if (minHeap.Count > k)
            {
                minHeap.Remove(minHeap.Min);
            }
        }

        // Extract the top k frequent elements from the heap
        IList<int> result = new List<int>();
        foreach (var kvp in minHeap)
        {
            result.Add(kvp.Key);
        }

        return result.Take(k).ToArray();
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
