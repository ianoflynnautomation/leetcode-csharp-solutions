using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode.Solutions
{
    public class _205_IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sMap = new Dictionary<char, char>();
            var tMap = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                if (sMap.ContainsKey(sChar))
                {
                    if (sMap[sChar] != tChar)
                    {
                        return false;
                    }
                }
                else
                {
                    if (tMap.ContainsKey(tChar))
                    {
                        return false;
                    }

                    sMap[sChar] = tChar;
                    tMap[tChar] = sChar;
                }
            }

            return true;
        }

    }
}