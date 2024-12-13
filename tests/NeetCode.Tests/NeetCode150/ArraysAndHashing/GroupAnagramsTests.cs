
namespace NeetCode.Tests.NeetCode150.ArraysAndHashing;

public class GroupAnagramsTests
{
    [Test]
    public void Case1()
    {
        var strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };

        var solution = new GroupAnagramsSolution();
        var result = solution.GroupAnagrams(strs);

        result.Should().BeEquivalentTo(new List<IList<string>>
        {
            new List<string> { "bat" },
            new List<string> { "tan", "nat" },
            new List<string> { "eat", "tea", "ate" }
        });
    }

    [Test]
    public void Case2()
    {
        var strs = new[] { "" };

        var solution = new GroupAnagramsSolution();
        var result = solution.GroupAnagrams(strs);

        result.Should().BeEquivalentTo(new List<IList<string>>
        {
            new List<string> { "" }
        });
    }

    [Test]
    public void Case3()
    {
        var strs = new[] { "a" };

        var solution = new GroupAnagramsSolution();
        var result = solution.GroupAnagrams(strs);

        result.Should().BeEquivalentTo(new List<IList<string>>
        {
            new List<string> { "a" }
        });
    }
}