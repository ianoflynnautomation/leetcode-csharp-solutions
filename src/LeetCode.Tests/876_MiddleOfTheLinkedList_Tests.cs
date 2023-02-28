
namespace LeetCode.Tests
{
    public class _876_MiddleOfTheLinkedList_Tests
    {
        [Test]
        public void Case1()
        {
            var head = TestsHelper.GenerateListNodeList(new int[] { 1, 2, 3, 4, 5 });

            var solution = new _876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(head);

            var expectedResult = TestsHelper.GenerateListNodeList(new int[] { 3, 4, 5 });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var head = TestsHelper.GenerateListNodeList(new int[] { 1, 2, 3, 4, 5, 6 });

            var solution = new _876_MiddleOfTheLinkedList();
            var result = solution.MiddleNode(head);

            var expectedResult = TestsHelper.GenerateListNodeList(new int[] { 4, 5, 6 });

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}