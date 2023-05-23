
namespace LeetCode.Solutions
{
    public class _17_LetterCombinationsOfAPhoneNumber
    {
        private readonly string[] PhoneDigits = {
            "",     // 0
            "",     // 1
            "abc",  // 2
            "def",  // 3
            "ghi",  // 4
            "jkl",  // 5
            "mno",  // 6
            "pqrs", // 7
            "tuv",  // 8
            "wxyz"  // 9
        };

        public IList<string> LetterCombinations(string digits)
        {

            IList<string> combinations = new List<string>();

            if (digits.Length == 0)
                return combinations;

            Backtrack(combinations, digits, new StringBuilder(), 0);

            return combinations;
        }

        private void Backtrack(IList<string> combinations, string digits, StringBuilder current, int index)
        {
            if (index == digits.Length)
            {
                combinations.Add(current.ToString());
                return;
            }

            int digit = int.Parse(digits[index].ToString());
            string letters = PhoneDigits[digit];

            for (int i = 0; i < letters.Length; i++)
            {
                current.Append(letters[i]);
                Backtrack(combinations, digits, current, index + 1);
                current.Remove(current.Length - 1, 1);
            }

        }
    }
}