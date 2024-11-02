namespace NeetCode.Solutions.NeetCode150.Stack;

[Level(Level.Medium)]
public class DailyTemperaturesSolution
{

    public int[] DailyTemperatures(int[] temperatures)
    {
        int[] results = new int[temperatures.Length];

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++)
        {
           var temperature = temperatures[i];

            while (stack.Count > 0 && temperatures[stack.Peek()] < temperature)
            {
                int index = stack.Pop();
                results[index] = i - index;
            }

            stack.Push(i);
        }

        return results;
    }
}