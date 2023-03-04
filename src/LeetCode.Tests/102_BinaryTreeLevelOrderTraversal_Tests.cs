
namespace LeetCode.Tests
{
    public class _102_BinaryTreeLevelOrderTraversal_Tests
    {
        [Test]
        public void Case1()
        {
            var root = TestsHelper.GenerateTreeNode(new int?[] { 3, 9, 20, null, null, 15, 7 });

            var solution = new _102_BinaryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(root);

            var expectedResult = new List<IList<int>>()
            {
                new List<int>() { 3 },
                new List<int>() { 9, 20 },
                new List<int>() { 15, 7 }
            };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var root = TestsHelper.GenerateTreeNode(new int?[] { 1 });

            var solution = new _102_BinaryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(root);

            var expectedResult = new List<IList<int>>()
            {
                new List<int>() { 1 }
            };

            result.Should().BeEquivalentTo(expectedResult);

        }

        [Test]
        public void Case3()
        {
            var root = TestsHelper.GenerateTreeNode(new int?[] { });

            var solution = new _102_BinaryTreeLevelOrderTraversal();
            var result = solution.LevelOrder(root);

            result.Should().BeEquivalentTo(new int?[] { });

        }
    }
}