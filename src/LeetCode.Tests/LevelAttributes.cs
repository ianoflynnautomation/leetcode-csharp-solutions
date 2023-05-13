
namespace LeetCode.Tests
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class LevelAttribute : System.Attribute
    {
        public string Level { get; set; }
        public LevelAttribute(string level)
        {
            Level = level;
        }
        
    }
}