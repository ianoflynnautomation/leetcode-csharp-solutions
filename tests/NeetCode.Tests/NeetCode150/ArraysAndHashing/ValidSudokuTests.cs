namespace NeetCode.Tests.NeetCode150.ArraysAndHashing;

public class ValidSudokuTests
{
    [Test]
    public void Case1()
    {
        var board = new char[][] {
            ['5','3','.','.','7','.','.','.','.'],
            ['6','.','.','1','9','5','.','.','.'],
            ['.','9','8','.','.','.','.','6','.'],
            ['8','.','.','.','6','.','.','.','3'],
            ['4','.','.','8','.','3','.','.','1'],
            ['7','.','.','.','2','.','.','.','6'],
            ['.','6','.','.','.','.','2','8','.'],
            ['.','.','.','4','1','9','.','.','5'],
            ['.','.','.','.','8','.','.','7','9']

        };

        var solution = new ValidSudokuSolution();
        var result = solution.IsValidSudoku(board);

        result.Should().BeTrue();
    }

    [Test]
    public void Case2()
    {

        var board = new char[][]{
            ['8','3','.','.','7','.','.','.','.'],
            ['6','.','.','1','9','5','.','.','.'],
            ['.','9','8','.','.','.','.','6','.'],
            ['8','.','.','.','6','.','.','.','3'],
            ['4','.','.','8','.','3','.','.','1'],
            ['7','.','.','.','2','.','.','.','6'],
            ['.','6','.','.','.','.','2','8','.'],
            ['.','.','.','4','1','9','.','.','5'],
            ['.','.','.','.','8','.','.','7','9']
        };

        var solution = new ValidSudokuSolution();
        var result = solution.IsValidSudoku(board);

        result.Should().BeFalse();

    }
}