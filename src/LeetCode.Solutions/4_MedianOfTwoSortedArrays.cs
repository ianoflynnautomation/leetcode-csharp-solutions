
namespace LeetCode.Solutions
{
    public class _4_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var s = nums1.Concat(nums2).OrderBy(x => x).ToArray();
            if (s.Length % 2 != 0)
            {
                return s[s.Length / 2];
            }
            return (double)(s[s.Length / 2] + s[(s.Length / 2) - 1]) / 2;

        }
    }
}