
namespace LeetCode.Solutions;

/// <summary>
/// 8. String to Integer (atoi)
/// https://leetcode.com/problems/string-to-integer-atoi/
/// 
/// Implement the myAtoi(string s) function, which converts a string to a 32-bit signed integer (similar to C/C++'s atoi function).
/// The algorithm for myAtoi(string s) is as follows:
/// 
/// Read in and ignore any leading whitespace.
/// Check if the next character (if not already at the end of the string) is '-' or '+'. Read this character in if it is either. 
/// This determines if the final result is negative or positive respectively. Assume the result is positive if neither is present.
/// Read in next the characters until the next non-digit character or the end of the input is reached. The rest of the string is ignored.
/// Convert these digits into an integer (i.e. "123" -> 123, "0032" -> 32). If no digits were read, 
/// then the integer is 0. Change the sign as necessary (from step 2).
/// If the integer is out of the 32-bit signed integer range [-231, 231 - 1], 
/// then clamp the integer so that it remains in the range. Specifically, 
/// integers less than -231 should be clamped to -231, and integers greater than 231 - 1 should be clamped to 231 - 1.
/// Return the integer as the final result.
/// Note:
/// Only the space character ' ' is considered a whitespace character.
/// Do not ignore any characters other than the leading whitespace or the rest of the string after the digits.
/// </summary>

[Companies(Company.Amazon, Company.Apple, Company.Microsoft)]
[Level(Level.Medium)]
public class _8_StringToIntegerAtoi
{
    public int MyAtoi(string s)
    {
        int index = 0;
        int sign = 1;
        int result = 0;

        // Discard all spaces from the beginning of the input string
        s = s.TrimStart(' ');

        // Check for sign 
        if (index < s.Length && s[index] == '+' || s[index] == '-')
        {
            sign = s[index] == '+' ? 1 : -1;
            index++;
        }

        // Convert digits
        while (index < s.Length && Char.IsDigit(s[index]))
        {
            int digit = s[index] - '0';

            //Check for overflow
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
            {
                return sign == 1 ? int.MaxValue : int.MinValue;
            }

            result = result * 10 + digit;
            index++;
        }

        return sign * result;

    }

}
