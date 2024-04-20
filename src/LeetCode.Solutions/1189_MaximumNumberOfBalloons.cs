namespace LeetCode.Solutions;

/// <summary>
/// 1189. Maximum Number of Balloons
/// https://leetcode.com/problems/maximum-number-of-balloons/
/// Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
/// You can use each character in text at most once. Return the maximum number of instances that can be formed.
/// </summary>
public class _1189_MaximumNumberOfBalloons
{
    public int MaxNumberOfBalloons(string text)
    {
        var dict = new Dictionary<char, int>
        {
            ['b'] = 0,
            ['a'] = 0,
            ['l'] = 0,
            ['o'] = 0,
            ['n'] = 0
        };

        foreach (var c in text)
        {
            if (dict.ContainsKey(c))
            {
                dict[c]++;
            }
        }

        dict['l'] /= 2;
        dict['o'] /= 2;

        return dict.Values.Min();
    }
}