namespace NeetCode.Tests.NeetCode150.BinarySearch
{
    public class EatingBananasTests
    {
        [Test]
        public void Case1()
        {
            var piles = new int[] { 1, 4, 3, 2 };
            var h = 9;
            var solution = new EatingBananasSolution();
            var result = solution.MinEatingSpeed(piles, h);
            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var piles = new int[] { 25, 10, 23, 4 };
            var h = 4;
            var solution = new EatingBananasSolution();
            var result = solution.MinEatingSpeed(piles, h);
            result.Should().Be(25);
        }

    }

}