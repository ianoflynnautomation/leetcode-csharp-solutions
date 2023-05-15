
namespace LeetCode.Solutions
{
    public class _8_StringToInteger
    {
        public int MyAtoi(string s)
        {

            int i = 0, sign = 1, result = 0;

            // Remove leading white space
            while (i < s.Length && s[i] == ' ')
            {
                i++;
            }

            // Check for sign
            if (i < s.Length && (s[i] == '+' || s[i] == '-'))
            {
                sign = s[i] == '+' ? 1 : -1;
                i++;
            }

            // Convert digits
            while (i < s.Length && Char.IsDigit(s[i]))
            {
                int digit = s[i] - '0';

                // Check for overflow
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7))
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }

                result = result * 10 + digit;
                i++;
            }

            return sign * result;
        }
    }
}