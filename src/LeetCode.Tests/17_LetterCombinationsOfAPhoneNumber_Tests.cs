
namespace LeetCode.Tests
{
    /// <summary>
    /// 17. Letter Combinations of a Phone Number
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// 
    /// Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent. 
    /// Return the answer in any order.
    /// A mapping of digits to letters (just like on the telephone buttons) is given below. 
    /// Note that 1 does not map to any letters.
    /// </summary>

    [Companies(Company.Amazon, Company.Apple, Company.Yahoo)]
    [Level(Level.Medium)]
    public class _17_LetterCombinationsOfAPhoneNumber_Tests
    {
        [Test]
        public void Case1()
        {
            var digits = "23";

            var solution = new _17_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations(digits);

            var expectedResult = new List<string>() { "ad", "ae", "af", "bd", "be", "bf", "cd", "ce", "cf" };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case2()
        {
            var digits = "";

            var solution = new _17_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations(digits);

            var expectedResult = new List<string>() { };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void Case3()
        {
            var digits = "2";

            var solution = new _17_LetterCombinationsOfAPhoneNumber();
            var result = solution.LetterCombinations(digits);

            var expectedResult = new List<string>() { "a", "b", "c" };

            result.Should().BeEquivalentTo(expectedResult);
        }


    }
}