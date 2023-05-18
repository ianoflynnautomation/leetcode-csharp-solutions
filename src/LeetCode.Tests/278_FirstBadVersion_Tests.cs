
namespace LeetCode.Tests
{
    /// <summary>
    /// 278. First Bad Version
    /// https://leetcode.com/problems/first-bad-version/
    /// 
    /// You are a product manager and currently leading a team to develop a new product. 
    /// Unfortunately, the latest version of your product fails the quality check. 
    /// Since each version is developed based on the previous version, all the versions after a bad version are also bad.
    /// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, 
    /// which causes all the following ones to be bad.
    /// You are given an API bool isBadVersion(version) which returns whether version is bad. 
    /// Implement a function to find the first bad version. You should minimize the number of calls to the API.
    /// </summary>

    [Companies(Company.Amazon, Company.Adobe, Company.Microsoft)]
    [Level(Level.Easy)]
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