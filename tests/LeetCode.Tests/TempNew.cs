
namespace LeetCode.Tests
{
    public class TempNew
    {
        [Test]
        public void Case1()
        {
            var array = new string[] { "Scientist", "Admin" };
            var result = SelectValue(array);
             //var result = SelectValueHashset(array);
            result.Should().Be("Scientist Admin active");

        }

        [Test]
        public void Case2()
        {
            var array = new string[] { "Scientist" };
          var result = SelectValue(array);
             //var result = SelectValueHashset(array);
            result.Should().Be("Scientist active only");

        }

        [Test]
        public void Case3()
        {
            var array = new string[] { "Admin" };
            var result = SelectValue(array);
             //var result = SelectValueHashset(array);
            result.Should().Be("Admin active only");

        }

        [Test]
        public void Case4()
        {
            var array = new string[] { };
             var result = SelectValue(array);
             //var result = SelectValueHashset(array);
            result.Should().Be("Scientist Admin inactive");


        }

        public string SelectValue(string[] array)
        {
            var result = string.Empty;
            if (array.Length == 0)
            {
                return result = "Scientist Admin inactive";

            }

            if (array.Length == 1)
            {
                if (array[0] == "Scientist")
                {
                    return result = "Scientist active only";
                }
                if (array[0] == "Admin")
                {
                    return result = "Admin active only";
                }

            }

            if (array.Length > 1)
            {
                return result = "Scientist Admin active";

            }

            return result;

        }

        public string SelectValueHashset(string[] array)
        {
            var hashset = new HashSet<string>(array);
            var result = string.Empty;
            if (hashset.Count == 0)
            {
                return result = "Scientist Admin inactive";

            }

            if (hashset.Count == 1)
            {
                if (hashset.Contains("Scientist"))
                {
                    return result = "Scientist active only";
                }
                if (hashset.Contains("Admin"))
                {
                    return result = "Admin active only";
                }

            }

              if (hashset.Contains("Scientist") && hashset.Contains("Admin"))
            {
                return result = "Scientist Admin active";

            }

            return result;

        }

    }
}