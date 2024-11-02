
namespace LeetCode.Solutions;
/// <summary>
/// 9. Palindrome Number
/// https://leetcode.com/problems/palindrome-number/
/// 
/// Given an integer x, return true if x is a palindrome, and false otherwise.
/// </summary>

[Companies(Company.Amazon, Company.Meta, Company.Google)]
[Level(Level.Easy)]
public class _9_PalindromeNumber
{
    public bool IsPalindrome(int x)
    {

        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversedNumber = 0;

        while (x > reversedNumber)
        {
            reversedNumber = (reversedNumber * 10) + (x % 10);
            x /= 10;
        }

        return x == reversedNumber || x == reversedNumber / 10;
    }
}
