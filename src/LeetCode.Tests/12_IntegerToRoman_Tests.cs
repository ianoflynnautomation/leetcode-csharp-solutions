
namespace LeetCode.Tests
{
    /// <summary>
    /// 12. Integer to Roman
    /// https://leetcode.com/problems/integer-to-roman/
    /// 
    /// oman numerals are represented by seven different symbols: I, V, X, L, C, D and M.
    /// Symbol       Value
    /// I             1
    /// V             5
    /// X             10
    /// L             50
    /// C             100
    /// D             500
    /// M             1000
    /// For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. 
    /// The number 27 is written as XXVII, which is XX + V + II.
    /// Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
    /// Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
    /// The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:
    /// I can be placed before V (5) and X (10) to make 4 and 9. 
    /// X can be placed before L (50) and C (100) to make 40 and 90. 
    /// C can be placed before D (500) and M (1000) to make 400 and 900.
    /// Given an integer, convert it to a roman numeral.
    /// </summary>

    [Companies(Company.Adobe, Company.Google, Company.Amazon)]
    [Level(Level.Medium)]
    public class _12_IntegerToRoman_Tests
    {
        [Test]
        public void Case1()
        {
            var solution = new _12_IntegerToRoman();
            var result = solution.IntToRoman(3);

            result.Should().Be("III");

        }

        [Test]
        public void Case2()
        {
            var solution = new _12_IntegerToRoman();
            var result = solution.IntToRoman(58);

            result.Should().Be("LVIII");

        }

        [Test]
        public void Case3()
        {
            var solution = new _12_IntegerToRoman();
            var result = solution.IntToRoman(1994);

            result.Should().Be("MCMXCIV");

        }

        [Test]
        public void Case4()
        {
            var solution = new _12_IntegerToRoman();
            var result = solution.IntToRoman(3888);

            result.Should().Be("MMMDCCCLXXXVIII");

        }
    }
}