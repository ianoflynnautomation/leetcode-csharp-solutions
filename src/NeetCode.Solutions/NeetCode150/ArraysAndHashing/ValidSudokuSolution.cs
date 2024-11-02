
namespace NeetCode.Solutions.NeetCode150.ArraysAndHashing;

/// <summary>
/// Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:
/// Each row must contain the digits 1-9 without repetition.
/// Each column must contain the digits 1-9 without repetition.
/// Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
/// Note:
/// A Sudoku board (partially filled) could be valid but is not necessarily solvable.
/// Only the filled cells need to be validated according to the mentioned rules.
/// </summary>

[Level(Level.Medium)]

public class ValidSudokuSolution
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

    public bool IsValidSudoku2(char[][] board)
    {
        var cols = new Dictionary<int, HashSet<char>>();
        var rows = new Dictionary<int, HashSet<char>>();
        var squares = new Dictionary<int, HashSet<char>>();  // key = (r / 3) * 3 + c / 3

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char cell = board[r][c];
                if (cell == '.')
                {
                    continue;
                }
                if (rows.TryGetValue(r, out var rowSet) && rowSet.Contains(cell)
                        || cols.TryGetValue(c, out var colSet) && colSet.Contains(cell)
                        || squares.TryGetValue((r / 3) * 3 + c / 3, out var squareSet) && squareSet.Contains(cell))
                {
                    return false;
                }
                cols.TryAdd(c, new HashSet<char>());
                rows.TryAdd(r, new HashSet<char>());
                squares.TryAdd((r / 3) * 3 + c / 3, new HashSet<char>());
                cols[c].Add(cell);
                rows[r].Add(cell);
                squares[(r / 3) * 3 + c / 3].Add(cell);
            }
        }
        return true;
    }
}