namespace NeetCode.Solutions.NeetCode150.Stack;

[Level(Level.Medium)]
public class MinimumStackSolution
{
    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;

    public MinimumStackSolution()
    {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        _stack.Push(val);

        var min = Math.Min(val, _minStack.Count == 0 ? val : _minStack.Peek());
        _minStack.Push(min);
    }

    public void Pop()
    {
        _stack.Pop();
        _minStack.Pop();
    }

    public int Top()
    {
        return _stack.Peek();
    }

    public int GetMin()
    {
        return _minStack.Peek();
    }
}