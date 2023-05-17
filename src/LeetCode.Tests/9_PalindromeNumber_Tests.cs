
namespace LeetCode.Tests
{
    /// <summary>
    /// 9. Palindrome Number
    /// https://leetcode.com/problems/palindrome-number/
    /// 
    /// Given an integer x, return true if x is a palindrome, and false otherwise.
    /// </summary>

    [Companies(Company.Amazon, Company.Meta, Company.Google)]
    [Level(Level.Easy)]
    public class _9_PalindromeNumber_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _9_PalindromeNumber();
            var result = solution.IsPalindrome(121);

            result.Should().BeTrue();

        }

        [Test]
        public void Case2()
        {
            var solution = new _9_PalindromeNumber();
            var result = solution.IsPalindrome(-121);

            result.Should().BeFalse();

        }

        [Test]
        public void Case3()
        {
            var solution = new _9_PalindromeNumber();
            var result = solution.IsPalindrome(10);

            result.Should().BeFalse();

        }
    }
}