using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class CitiesShould
{
    [Test]
    public void NotFindAnyCitiesWhenTheInputIsEmpty()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("");
        result.Should().BeEmpty();
    }
    
    [Test]
    public void NotFindAnyCitiesWhenTheInputLengthIsLessThanTree()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Pa");
        result.Should().BeEmpty();
    }
}