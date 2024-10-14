
// namespace LeetCode.Tests
// {
//     public class _589_NaryTreePreorderTraversal_Tests
//     {
//         [Test]
//         public void Case1()
//         {
//             var root = new Node(1, new List<Node>()
//             {
//                 new Node(3, new List<Node>()
//                 {
//                     new Node(5),
//                     new Node(6),
//                 }),
//                 new Node(2),
//                 new Node(4),
//             });

//             var solution = new _589_NaryTreePreorderTraversal();
//             var result = solution.Preorder(root);

//             var expectedResult = new int[] { 1, 3, 5, 6, 2, 4 };

//             result.Should().BeEquivalentTo(expectedResult);
//         }

//         [Test]
//         public void Case2()
//         {
//             var root = new Node(1, new List<Node>()
//             {
//                 new Node(2),
//                 new Node(3, new List<Node>()
//                 {
//                     new Node(6),
//                     new Node(7, new List<Node>()
//                     {
//                         new Node(11, new List<Node>()
//                         {
//                             new Node(14),
//                         })
//                     }),
//                 }),
//                 new Node(4, new List<Node>()
//                 {
//                     new Node(8, new List<Node>()
//                     {
//                         new Node(12),
//                     })
//                 }),
//                 new Node(5, new List<Node>()
//                 {
//                     new Node(9, new List<Node>()
//                     {
//                         new Node(13),
//                     }),
//                     new Node(10),
//                 }),
//             });

//             var solution = new _589_NaryTreePreorderTraversal();
//             var result = solution.Preorder(root);

//             var expectedResult = new int[] { 1, 2, 3, 6, 7, 11, 14, 4, 8, 12, 5, 9, 13, 10 };

//             result.Should().BeEquivalentTo(expectedResult);

//         }
//     }
// }