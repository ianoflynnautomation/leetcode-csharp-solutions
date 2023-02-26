
namespace LeetCode.Tests
{
    public class _205_IsomorphicStrings_Tests
    {
        [Test]
        public void Case1()
        {
            var s = "egg";
            var t = "add";

            var solution = new _205_IsomorphicStrings();
            var result = solution.IsIsomorphic(s, t);

            result.Should().BeTrue();
        }

        [Test]
        public void Case2()
        {
            var s = "foo";
            var t = "bar";

            var solution = new _205_IsomorphicStrings();
            var result = solution.IsIsomorphic(s, t);

            result.Should().BeFalse();
        }

        [Test]
        public void Case3()
        {
            var s = "paper";
            var t = "title";

            var solution = new _205_IsomorphicStrings();
            var result = solution.IsIsomorphic(s, t);

            result.Should().BeTrue();
        }
    }
}