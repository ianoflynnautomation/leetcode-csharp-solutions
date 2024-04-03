
namespace LeetCode.Solutions.Attributes;

    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class LevelAttribute : System.Attribute
    {
        public Level Level { get; set; }
        public LevelAttribute(Level level)
        {
            Level = level;
        }
        
    }