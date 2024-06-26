

namespace LeetCode.Solutions;

/// <summary>
/// 67. Add Binary
/// https://leetcode.com/problems/add-binary/
/// 
/// Given two binary strings a and b, return their sum as a binary string.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Bloomberg)]
[Level(Level.Easy)]
public class _67_AddBinary
{
    public string AddBinary(string a, string b)
    {
        StringBuilder result = new StringBuilder();
        int carry = 0, i = a.Length - 1, j = b.Length - 1;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0';
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0';
                j--;
            }

            result.Append(sum % 2);
            carry = sum / 2;
        }

        return new string(result.ToString().Reverse().ToArray());
    }
}