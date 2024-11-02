namespace NeetCode.Solutions.NeetCode150.Stack;

[Level(Level.Medium)]
public class EvaluateReversePolishNotationSolution
{
    [TimeComplexity("O(n)")]
    [SpaceComplexity("O(n)")]
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (token == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (token == "-")
            {
                var val1 = stack.Pop();
                var val2 = stack.Pop();

                stack.Push(val2 - val1);
            }
            else if (token == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (token == "/")
            {
                var val1 = stack.Pop();
                var val2 = stack.Pop();

                stack.Push(val1 / val2);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}