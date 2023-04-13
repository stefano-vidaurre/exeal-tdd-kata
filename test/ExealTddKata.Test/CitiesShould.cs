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
    public void NotFindAnyCitiesWhenTheInputLengthIsLessThanTwo()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("P");
        result.Should().BeEmpty();
    }
    
    [Test]
    public void FindParisWhenTheInputIsPar()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Par");
        result.Should().Contain("Paris");
    }
}