namespace LeetCode.Solutions;

/// <summary>
/// 36. Valid Sudoku
/// https://leetcode.com/problems/valid-sudoku/
/// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
/// Each row must contain the digits 1-9 without repetition.
/// Each column must contain the digits 1-9 without repetition.
/// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// Note:
/// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
/// Only the filled cells need to be validated according to the mentioned rules.
/// </summary>

[Level(Level.Medium)]

public class _36_ValidSudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var rows = new HashSet<string>();
        var columns = new HashSet<string>();
        var boxes = new HashSet<string>();

        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                char cell = board[i][j];
                if (cell == '.')
                {
                    continue;
                }

                var rowKey = $"{cell} in row {i}";
                var columnKey = $"{cell} in column {j}";
                var boxKey = $"{cell} in box {i / 3} - {j / 3}";

                if (!rows.Add(rowKey) || !columns.Add(columnKey) || !boxes.Add(boxKey))
                {
                    return false;
                }
            }
        }

        return true;
    }
}