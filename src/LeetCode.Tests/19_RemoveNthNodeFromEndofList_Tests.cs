
namespace LeetCode.Tests
{
    /// <summary>
    /// 19. Remove Nth Node From End of List
    /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    /// 
    /// Given the head of a linked list, remove the nth node from the end of the list and return its head.
    /// </summary>

    [Companies(Company.Amazon, Company.Apple, Company.Google)]
    [Level(Level.Medium)]
    public class _19_RemoveNthNodeFromEndofList_Tests
    {
        [Test]
        public void Case1()
        {
            var head = TestsHelper.GenerateListNode(new int[] { 1, 2, 3, 4, 5 });
            var n = 2;

            var solution = new _19_RemoveNthNodeFromEndofList();
            var result = solution.RemoveNthFromEnd(head, n);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 1, 2, 3, 5 });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var head = TestsHelper.GenerateListNode(new int[] { 1 });
            var n = 1;

            var solution = new _19_RemoveNthNodeFromEndofList();
            var result = solution.RemoveNthFromEnd(head, n);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case3()
        {
            var head = TestsHelper.GenerateListNode(new int[] { 1, 2 });
            var n = 1;

            var solution = new _19_RemoveNthNodeFromEndofList();
            var result = solution.RemoveNthFromEnd(head, n);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 1 });

            result.Should().BeEquivalentTo(expectedResult);
        }

    }
}