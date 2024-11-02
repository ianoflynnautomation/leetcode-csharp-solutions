namespace LeetCode.Tests;
public class _155_MinStack_Tests
{
    [Test]
    public void Case1()
    {
        MinStack minStack = new MinStack();
        minStack.Push(-2);
        minStack.Push(0);
        minStack.Push(-3);
        minStack.GetMin().Should().Be(-3);
        minStack.Pop();
        minStack.Top().Should().Be(0);
        minStack.GetMin().Should().Be(-2);

    }
}


