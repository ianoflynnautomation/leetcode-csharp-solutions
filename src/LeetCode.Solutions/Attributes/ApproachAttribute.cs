
using LeetCode.Solutions.Enums;

namespace LeetCode.Solutions.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class ApproachAttribute : System.Attribute
    {
        public Approach Approach { get; set; }
        public ApproachAttribute(Approach spaceComplexity)
        {
            Approach = spaceComplexity;
        }
    }
}