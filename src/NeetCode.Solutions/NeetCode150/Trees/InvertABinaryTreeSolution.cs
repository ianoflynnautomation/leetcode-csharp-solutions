namespace NeetCode.Solutions.NeetCode150.Trees;

[Level(Level.Medium)]
public class InvertABinaryTreeSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        var node = new TreeNode(root.val)
        {
            left = InvertTree(root.left),
            right = InvertTree(root.right)
        };

        return node;
    }
}