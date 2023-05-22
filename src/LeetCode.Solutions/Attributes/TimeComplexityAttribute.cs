
namespace LeetCode.Solutions.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class TimeComplexityAttribute : System.Attribute
    {
        public string TimeComplexity { get; set; }
        public TimeComplexityAttribute(string timeComplexity)
        {
            TimeComplexity = timeComplexity;
        }
    }
}