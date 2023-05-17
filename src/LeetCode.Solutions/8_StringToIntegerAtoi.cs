
namespace LeetCode.Solutions;
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
