
namespace LeetCode.Tests
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class CompaniesAttribute : System.Attribute
    {
        public string Companies { get; set; }
        public CompaniesAttribute(string companies )
        {
            Companies = companies;
        }
        
    }
}