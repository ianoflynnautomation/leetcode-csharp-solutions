
namespace LeetCode.Tests
{
    /// <summary>
    /// 205. Isomorphic Strings
    /// https://leetcode.com/problems/isomorphic-strings/
    /// 
    /// Given two strings s and t, determine if they are isomorphic.
    /// Two strings s and t are isomorphic if the characters in s can be replaced to get t.
    /// All occurrences of a character must be replaced with another character while preserving the order of characters. 
    /// No two characters may map to the same character, but a character may map to itself.
    /// </summary>

    [Companies(Company.Micrsoft, Company.LinkedIn, Company.Amazon)]
    [Level(Level.Easy)]
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