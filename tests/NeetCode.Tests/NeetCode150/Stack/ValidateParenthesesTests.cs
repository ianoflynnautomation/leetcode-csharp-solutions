namespace NeetCode.Tests.NeetCode150.Stack;

public class ValidateParenthesesTests
{
    
        [Test]
        public void Case1()
        {
            var s = "()";
            var solution = new ValidateParenthesesSolution();
            var result = solution.IsValid(s);
            result.Should().BeTrue();
        }
    
        [Test]
        public void Case2()
        {
            var s = "()[]{}";
            var solution = new ValidateParenthesesSolution();
            var result = solution.IsValid(s);
            result.Should().BeTrue();
        }
    
        [Test]
        public void Case3()
        {
            var s = "(]";
            var solution = new ValidateParenthesesSolution();
            var result = solution.IsValid(s);
            result.Should().BeFalse();
        }
    
        [Test]
        public void Case4()
        {
            var s = "([)]";
            var solution = new ValidateParenthesesSolution();
            var result = solution.IsValid(s);
            result.Should().BeFalse();
        }
    
        [Test]
        public void Case5()
        {
            var s = "{[]}";
            var solution = new ValidateParenthesesSolution();
            var result = solution.IsValid(s);
            result.Should().BeTrue();
        }
}