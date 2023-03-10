
namespace LeetCode.Tests
{
    public class _21_MergeTwoSortedLists_Tests
    {
        [Test]
        public void Case1()
        {
            var list1 = TestsHelper.GenerateListNode(new int[] { 1, 2, 4 });
            var list2 = TestsHelper.GenerateListNode(new int[] { 1, 3, 4 });

            var solution = new _21_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 1, 1, 2, 3, 4, 4 });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var list1 = TestsHelper.GenerateListNode(new int[] { });
            var list2 = TestsHelper.GenerateListNode(new int[] { });

            var solution = new _21_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { });

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case3()
        {
            var list1 = TestsHelper.GenerateListNode(new int[] { });
            var list2 = TestsHelper.GenerateListNode(new int[] { 0 });

            var solution = new _21_MergeTwoSortedLists();
            var result = solution.MergeTwoLists(list1, list2);

            var expectedResult = TestsHelper.GenerateListNode(new int[] { 0 });

            result.Should().BeEquivalentTo(expectedResult);
        }
        
    }
}