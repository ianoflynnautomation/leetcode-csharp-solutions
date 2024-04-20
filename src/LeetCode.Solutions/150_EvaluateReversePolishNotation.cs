namespace LeetCode.Solutions;

/// <summary>
/// 150. Evaluate Reverse Polish Notation
/// https://leetcode.com/problems/evaluate-reverse-polish-notation/
/// You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.
/// Evaluate the expression. Return an integer that represents the value of the expression.
/// 
/// Note that:
/// The valid operators are '+', '-', '*', and '/'.
/// Each operand may be an integer or another expression.
/// The division between two integers always truncates toward zero.
/// There will not be any division by zero.
/// The input represents a valid arithmetic expression in a reverse polish notation.
/// The answer and all the intermediate calculations can be represented in a 32-bit integer.

[Level(Level.Medium)]
public class _150_EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        var operators = new HashSet<string> { "+", "-", "*", "/" };
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (operators.Contains(token))
            {
                int number1 = stack.Pop();
                int number2 = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(number2 + number1);
                        break;
                    case "-":
                        stack.Push(number2 - number1);
                        break;
                    case "*":
                        stack.Push(number2 * number1);
                        break;
                    case "/":
                        stack.Push(number2 / number1);
                        break;
                }
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
        return stack.Pop();

    }

}