namespace NeetCode.Solutions.NeetCode150.Stack;

[Level(Level.Medium)]
public class CarFleetSolution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new List<(int position, double time)>();

        // Calculate time to reach target for each car
        for (int i = 0; i < position.Length; i++)
        {
            double time = (double)(target - position[i]) / speed[i];
            cars.Add((position[i], time));
        }

        // Sort cars by their starting position in descending order
        cars.Sort((a, b) => b.position.CompareTo(a.position));

        var stack = new Stack<double>();

        // Process each car from the closest to the target to the furthest
        foreach (var car in cars)
        {
            if (stack.Count == 0 || car.time > stack.Peek())
            {
                // Start a new fleet if this car has a greater time to target
                stack.Push(car.time);
            }
            // If car.time <= stack.Peek(), it joins the current fleet (do nothing)
        }

        // The number of fleets is the size of the stack
        return stack.Count;

    }

}