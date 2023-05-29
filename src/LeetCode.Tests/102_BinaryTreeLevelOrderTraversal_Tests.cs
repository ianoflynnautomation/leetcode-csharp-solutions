
namespace LeetCode.Tests;

/// <summary>
/// 102. Binary Tree Level Order Traversal
/// https://leetcode.com/problems/binary-tree-level-order-traversal/
/// 
/// Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).
/// </summary>

[Companies(Company.Amazon, Company.Bloomberg, Company.LinkedIn)]
[Level(Level.Medium)]
public class _102_BinaryTreeLevelOrderTraversal_Tests
{
    [Test]
    public void Case1()
    {
        var root = NodeGenerator.TreeNode(new int?[] { 3, 9, 20, null, null, 15, 7 });

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
        var root = NodeGenerator.TreeNode(new int?[] { 1 });

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
        var root = NodeGenerator.TreeNode(new int?[] { });

        var solution = new _102_BinaryTreeLevelOrderTraversal();
        var result = solution.LevelOrder(root);

        result.Should().BeEquivalentTo(new int?[] { });
    }

}