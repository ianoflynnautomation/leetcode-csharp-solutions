
namespace LeetCode.Tests
{
    public class _5_LongestPalindromicSubstring_Tests
    {
        [Test]
        public void Case1()
        {
            var s = "babad";

            var solution = new _5_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(s);

            result.Should().Be("aba");

        }

        [Test]
        public void Case2()
        {
            var s = "cbbd";

            var solution = new _5_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(s);

            result.Should().Be("bb");

        }

    }
}