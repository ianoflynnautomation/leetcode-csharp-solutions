using Core.Enums;

namespace Core.Attributes;

    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class ApproachAttribute : System.Attribute
    {
        public Approach Approach { get; set; }
        public ApproachAttribute(Approach spaceComplexity)
        {
            Approach = spaceComplexity;
        }
    }