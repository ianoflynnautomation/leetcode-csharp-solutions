
using System.Text;

namespace LeetCode.Solutions;

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
public class _17_LetterCombinationsOfAPhoneNumber
{
    private readonly string[] PhoneDigits = {
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
        };

    public IList<string> LetterCombinations(string digits)
    {

        IList<string> combinations = new List<string>();

        if (digits.Length == 0)
            return combinations;

        Backtrack(combinations, digits, new StringBuilder(), 0);

        return combinations;
    }

    private void Backtrack(IList<string> combinations, string digits, StringBuilder current, int index)
    {
        if (index == digits.Length)
        {
            combinations.Add(current.ToString());
            return;
        }

        int digit = int.Parse(digits[index].ToString());
        string letters = PhoneDigits[digit];

        for (int i = 0; i < letters.Length; i++)
        {
            current.Append(letters[i]);
            Backtrack(combinations, digits, current, index + 1);
            current.Remove(current.Length - 1, 1);
        }

    }
}