
namespace LeetCode.Tests
{
    /// <summary>
    /// 11. Container With Most Water
    /// https://leetcode.com/problems/container-with-most-water/description/
    /// 
    /// You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
    /// Find two lines that together with the x-axis form a container, such that the container contains the most water.
    /// Return the maximum amount of water a container can store.
    /// Notice that you may not slant the container.
    /// </summary>


    [Companies(Company.Amazon, Company.Micrsoft, Company.Adobe)]
    [Level(Level.Medium)]
    public class _11_ContainerWithMostWater_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _11_ContainerWithMostWater();
            var result = solution.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });

            result.Should().Be(49);

        }

        [Test]
        public void Case2()
        {
            var solution = new _11_ContainerWithMostWater();
            var result = solution.MaxArea(new int[] { 1, 1 });

            result.Should().Be(1);

        }
    }
}