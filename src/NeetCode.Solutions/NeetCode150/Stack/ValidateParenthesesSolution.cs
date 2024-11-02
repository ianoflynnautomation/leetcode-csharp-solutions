namespace NeetCode.Solutions.NeetCode150.Stack;

[Level(Level.Easy)]
public class ValidateParenthesesSolution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (stack.Count> 0 && c == '}' && stack.Peek() == '{' )
            {
                stack.Pop();
            }
            else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}