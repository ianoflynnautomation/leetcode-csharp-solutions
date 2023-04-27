
namespace LeetCode.Tests
{
    public class _27_RemoveElement_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _27_RemoveElement();
            var result = solution.RemoveElement(new[] { 3, 2, 2, 3 }, 3);

            result.Should().Be(2);
        }

        [Test]
        public void Case2()
        {
            var solution = new _27_RemoveElement();
            var result = solution.RemoveElement(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);

            result.Should().Be(5);
        }
    }
}