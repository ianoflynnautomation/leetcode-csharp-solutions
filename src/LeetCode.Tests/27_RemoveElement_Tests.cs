
namespace LeetCode.Tests
{
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
    
    [Companies("Amazon, Facebook, Adobe")]
    [Level("Easy")]
    public class _27_RemoveElement_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _27_RemoveElement();
            var result = solution.RemoveElement(new[] { 3, 2, 2, 3 }, 3);

            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var solution = new _27_RemoveElement();
            var result = solution.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            result.Should().Be(5);
        }
    }
}