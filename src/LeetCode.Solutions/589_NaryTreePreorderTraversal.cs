
namespace LeetCode.Solutions;

public class _589_NaryTreePreorderTraversal
{

    /*
    // Definition for a Node.
    public class Node {
        public int val;
        public IList<Node> children;

        public Node() {}

        public Node(int _val) {
            val = _val;
        }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }
    */

    public IList<int> Preorder(Node root)
    {

        IList<int> result = new List<int>();

        PreorderHelper(root, result);

        return result;
    }

    private void PreorderHelper(Node node, IList<int> list)
    {
        if (node == null)
        {
            return;
        }
        list.Add(node.val);
        foreach (Node child in node.children)
        {
            PreorderHelper(child, list);
        }
    }

}