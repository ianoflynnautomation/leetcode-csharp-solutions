
namespace LeetCode.Solutions.Attributes;

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class SpaceComplexityAttribute : System.Attribute
    {
        public string SpaceComplexity { get; set; }
        public SpaceComplexityAttribute(string spaceComplexity)
        {
            SpaceComplexity = spaceComplexity;
        }
    }