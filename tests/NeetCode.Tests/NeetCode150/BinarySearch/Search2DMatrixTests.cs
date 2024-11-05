namespace NeetCode.Tests.NeetCode150.BinarySearch;
    public class Search2DMatrixTests
    {
        [Test]
        public void Case1()
        {
            var matrix = new int[][]
            {
                [1, 2, 4, 8],
                [10, 11, 12, 13],
                [14, 20, 30, 40]
            };

            var target = 15;
            var solution = new Search2DMatrixSolution();
            var result = solution.SearchMatrix(matrix, target);
            result.Should().BeFalse();
        }

        [Test]
        public void Case2()
        {
            var matrix = new int[][]
            {
                [1, 2, 4, 8],
                [10, 11, 12, 13],
                [14, 20, 30, 40]
            };

            var target = 10;
            var solution = new Search2DMatrixSolution();
            var result = solution.SearchMatrix(matrix, target);
            result.Should().BeTrue();
        }
    }