
namespace LeetCode.Solutions
{
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
    public class _102_BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {

            IList<IList<int>> result = new List<IList<int>>();

            LevelOrderHelper(root, 0, result);

            return result;
        }

        private void LevelOrderHelper(TreeNode node, int level, IList<IList<int>> result)
        {
            if (node == default)
            {
                return;
            }
            if (level >= result.Count)
            {
                result.Add(new List<int>());
            }
            result[level].Add(node.val);
            LevelOrderHelper(node.left, level + 1, result);
            LevelOrderHelper(node.right, level + 1, result);
        }

    }
}