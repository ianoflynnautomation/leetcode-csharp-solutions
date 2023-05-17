using System.Text;

namespace LeetCode.Solutions
{
    public class _12_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            var values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            var symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder sb = new StringBuilder();

            // Loop through each symbol stopping if num becomes 0
            for (int i = 0; i < values.Length && num > 0; i++)
            {
                while (values[i] <= num)
                {
                    num -= values[i];
                    sb.Append(symbols[i]);
                }
            }

            return sb.ToString();
        }
    }
}