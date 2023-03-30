using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class FibonacciShould
{
    [Test]
    public void ReturnZeroWhenInputIsZero()
    {
        int result = Fibonacci.Calc(0);
        result.Should().Be(0);
    }
    
    [Test]
    public void ReturnOneWhenInputIsOne()
    {
        int result = Fibonacci.Calc(1);
        result.Should().Be(1);
    }

    [Test]
    public void ReturnOneWhenInputIsTwo()
    {
        int result = Fibonacci.Calc(2);
        result.Should().Be(1);
    }

    [Test]
    public void ReturnTwoWhenInputIsThree()
    {
        int result = Fibonacci.Calc(3);
        result.Should().Be(2);
    }

    [Test]
    public void ReturnThreeWhenInputIsFour()
    {
        int result = Fibonacci.Calc(4);
        result.Should().Be(3);
    }
}