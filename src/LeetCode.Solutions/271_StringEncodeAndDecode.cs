namespace LeetCode.Solutions;

[Level(Level.Medium)]
public class _271_StringEncodeAndDecode
{
    public string Encode(List<string> strs)
    {
        return string.Concat(strs.SelectMany(s => $"{s.Length}#{s}"));
    }

    public List<string> Decode(string s)
    {
        var res = new List<string>();

        var i = 0;
        while (i < s.Length)
        {
            var j = i;
            while (s[j] != '#')
            {
                ++j;
            }

            int.TryParse(s.Substring(i, j - i), out var len);
            j++;
            res.Add(s.Substring(j, len));
            i = j + len;
        }

        return res;
    }
}