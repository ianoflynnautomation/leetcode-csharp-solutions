namespace NeetCode.Solutions.NeetCode150.BinarySearch;

[Level(Level.Medium)]
public class Search2DMatrixSolution
{
    [TimeComplexity("O(logm + log⁡n)")]
    [SpaceComplexity("O(1)")]
    public bool SearchMatrix(int[][] matrix, int target) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int left = 0;
        int right = rows * cols - 1;

        while(left <= right)
        {
            int mid = left + (right - left) / 2;

            int row = mid / cols;
            int col = mid % cols;

            if(target == matrix[row][col])
            {
                return true;
            }
            else if (target > matrix[row][col])
            {
                left = mid + 1;
            }
            else{
                right = mid - 1;
            }
        }
        return false;
    }
}