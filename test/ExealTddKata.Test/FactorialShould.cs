using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class FactorialShould
{
    [Test]
    public void ReturnOneWhenInputIsZero()
    {
        int result = Factorial.Calc(0);
        result.Should().Be(1);
    }
    
    [Test]
    public void ReturnTwoWhenInputIsTwo()
    {
        int result = Factorial.Calc(2);
        result.Should().Be(2);
    }
    
    [Test]
    public void ReturnSixWhenInputIsThree()
    {
        int result = Factorial.Calc(3);
        result.Should().Be(6);
    }
    
    [Test]
    public void ReturnTwentyFourWhenInputIsThree()
    {
        int result = Factorial.Calc(4);
        result.Should().Be(24);
    }
}