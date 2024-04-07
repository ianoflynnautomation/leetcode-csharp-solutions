
namespace LeetCode.Solutions;

/// <summary>
/// 155. Min Stack
/// https://leetcode.com/problems/min-stack/
/// Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
/// Implement the MinStack class:
/// MinStack() initializes the stack object.
/// void push(val) pushes the element val onto the stack.
/// void pop() removes the element on the top of the stack.
/// int top() gets the top element of the stack.
/// int getMin() retrieves the minimum element in the stack.
/// </summary>

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

[Level(Level.Medium)]
public class MinStack
{
    Stack<int> stack;
    Stack<int> minimumStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minimumStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);

        if (minimumStack.Count == 0 || val <= minimumStack.Peek())
        {
            minimumStack.Push(val);
        }
    }

    public void Pop()
    {
        var val = stack.Pop();
        if (minimumStack.Count > 0 && val == minimumStack.Peek())
        {
            minimumStack.Pop();
        }
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minimumStack.Peek();
    }
}