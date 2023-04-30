
namespace LeetCode.Tests
{
    public class _4_MedianOfTwoSortedArrays_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _4_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 });

            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var solution = new _4_MedianOfTwoSortedArrays();

            var result = solution.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 });

            result.Should().Be(2.5);

        }

    }
}