
namespace LeetCode.Solutions;

/// <summary>
/// 6. ZigZag Conversion
/// https://leetcode.com/problems/zigzag-conversion/
/// 
/// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: 
/// (you may want to display this pattern in a fixed font for better legibility)
/// </summary>

[Companies(Company.Amazon, Company.Yahoo, Company.Apple)]
[Level(Level.Medium)]
public class _6_ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;

        char[,] grid = new char[numRows, s.Length];

        int row = 0, col = 0;
        bool goingDown = true;

        foreach (char c in s)
        {
            grid[row, col] = c;

            if (goingDown && row == numRows - 1)
            {
                goingDown = false;
            }
            else if (!goingDown && row == 0)
            {
                goingDown = true;
            }

            row += goingDown ? 1 : -1;
            col++;
        }

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (grid[i, j] != '\0')
                {
                    result.Append(grid[i, j]);
                }
            }
        }

        return result.ToString();
    }

}
