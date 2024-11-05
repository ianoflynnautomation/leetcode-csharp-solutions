namespace NeetCode.Solutions.NeetCode150.BinarySearch;

[Level(Level.Medium)]
public class EatingBananasSolution
{
    [TimeComplexity("O(n * log m)")]
    [SpaceComplexity("O(1)")]
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            long totalTime = 0;

            foreach (int p in piles)
            {
                totalTime += (int)Math.Ceiling((double)p / mid);
            }

            if (totalTime <= h)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }

        }
        return result;
    }
}