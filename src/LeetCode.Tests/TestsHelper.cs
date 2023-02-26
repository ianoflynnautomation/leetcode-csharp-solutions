
namespace LeetCode.Tests
{
    public static class TestsHelper
    {
         public static ListNode? GenerateListNodeList(int[] nums)
        {
            if (nums == null || nums.Length == 0) return null; 

            var i = 0;
            var first = new ListNode(nums[i]);
            var current = first;

            while (++i < nums.Length)
            {
                current.next = new ListNode(nums[i]);
                current = current.next;
            }

            return first;
        }
    }
}