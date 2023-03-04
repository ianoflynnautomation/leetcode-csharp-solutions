
namespace LeetCode.Tests
{
    public class _278_FirstBadVersion_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _278_FirstBadVersion();
            var result = solution.FirstBadVersion(5);
            result.Should().Be(4);
        }

        [Test]
        public void Case2()
        {
            var solution = new _278_FirstBadVersion();
            var result = solution.FirstBadVersion(1);
            result.Should().Be(1);
        }

    }
}