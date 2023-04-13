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
    public void FindParisWhenTheInputIsPa()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Pa");
        result.Should().Contain("Paris");
    }
    
    [Test]
    public void FindValenciaWhenTheInputIsVa()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Va");
        
        result.Should().Contain("Valencia");
    }
    
    [Test]
    public void FindBudapestWhenTheInputIsBu()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Bu");
        
        result.Should().Contain("Budapest");
    }
    
    [Test]
    public void FindVancouverAndValenciaWhenTheInputIsVa()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("Va");
        
        result.Should().Contain("Vancouver");
        result.Should().Contain("Valencia");
    }
    
    [Test]
    public void FindBudapestWhenTheInputIsOnlyLowerCase()
    {
        Cities cities = new Cities();
        IEnumerable<string> result = cities.Find("bu");
        
        result.Should().Contain("Budapest");
    }
}