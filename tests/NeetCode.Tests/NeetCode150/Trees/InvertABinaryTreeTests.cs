using Core.Helpers;
using NeetCode.Solutions.NeetCode150.Trees;

namespace NeetCode.Tests.NeetCode150.Trees;

public class InvertABinaryTreeTests
{
    [Test]
    public void Case1()
    {
        var root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(7, new TreeNode(6), new TreeNode(9)));

        var solution = new InvertABinaryTreeSolution();
        var result = solution.InvertTree(root);

        var expectedResult = new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1)));

        result.Should().BeEquivalentTo(expectedResult);
    }
    
}