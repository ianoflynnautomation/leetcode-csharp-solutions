
namespace LeetCode.Tests
{
    /// <summary>
    /// 876. Middle of the Linked List
    /// https://leetcode.com/problems/middle-of-the-linked-list/
    ///   
    /// Given the head of a singly linked list, return the middle node of the linked list.
    /// If there are two middle nodes, return the second middle node.
    /// </summary>

    [Companies(Company.Amazon, Company.Google, Company.Adobe)]
    [Level(Level.Easy)]
    public class _876_MiddleOfTheLinkedList_Tests
    {
        [Test]
        public void Case1()
        {
            var head = TestsHelper.GenerateListNode(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(head);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 3, 4, 5 });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var head = TestsHelper.GenerateListNode(new int[] { 1, 2, 3, 4, 5, 6 });

            var solution = new _876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(head);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 4, 5, 6 });

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}