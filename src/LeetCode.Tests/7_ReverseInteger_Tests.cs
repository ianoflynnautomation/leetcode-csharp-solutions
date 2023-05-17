
namespace LeetCode.Tests
{
    /// <summary>
    /// 7. Reverse Integer
    /// https://leetcode.com/problems/reverse-integer/
    /// 
    /// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
    /// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).
    /// </summary>

    [Companies(Company.Amazon, Company.Apple, Company.Microsoft)]
    [Level(Level.Medium)]
    public class _7_ReverseInteger_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _7_ReverseInteger();
            var result = solution.Reverse(123);

            result.Should().Be(321);
        }

        [Test]
        public void Case2()
        {
            var solution = new _7_ReverseInteger();
            var result = solution.Reverse(-123);

            result.Should().Be(-321);
        }

        [Test]
        public void Case3()
        {
            var solution = new _7_ReverseInteger();
            var result = solution.Reverse(120);

            result.Should().Be(21);
        }
    }

}

