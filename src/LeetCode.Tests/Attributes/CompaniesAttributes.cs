
namespace LeetCode.Tests
{
    [System.AttributeUsage(System.AttributeTargets.Class)]
    public class CompaniesAttribute : System.Attribute
    {
        public Company[] Companies{ get; set; }
        public CompaniesAttribute(params Company[] companies )
        {
            Companies = companies;
        }    
           
    }
}