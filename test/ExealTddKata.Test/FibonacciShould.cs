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
    // TODO: Casos n > 1
}