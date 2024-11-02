namespace LeetCode.Solutions;

/// <summary>
/// 25. Valid Palindrome
/// https://leetcode.com/problems/valid-palindrome/
/// Given a string s, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
/// Note: For the purpose of this problem, we define empty string as valid palindrome.
/// </summary>
public class _25_ValidPalindrome
{
    public bool IsPalindrome(string s)
    {

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left])) { left++; }
            else if (!char.IsLetterOrDigit(s[right])) { right--; }
            else
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }
}