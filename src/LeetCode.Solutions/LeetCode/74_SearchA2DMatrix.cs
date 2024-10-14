namespace LeetCode.Solutions;

/// <summary>
/// 74. Search a 2D Matrix
/// https://leetcode.com/problems/search-a-2d-matrix/
/// Write an efficient algorithm that searches for a value in an m x n matrix.
/// This matrix has the following properties:
/// Integers in each row are sorted from left to right.
/// 
/// </summary>

[Level(Level.Medium)]
public class _74_SearchA2DMatrix
{
    
    public bool SearchMatrix(int[][] matrix, int target)
    {
        var row = matrix.Length;
        var col = matrix[0].Length;
        var left = 0;
        var right = row * col - 1;

        while(left <= right)
        {
            var mid = left + (right - left) / 2;
            var midValue = matrix[mid / col][mid % col];

            if(midValue == target)
            {
                return true;
            }
            else if(midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}