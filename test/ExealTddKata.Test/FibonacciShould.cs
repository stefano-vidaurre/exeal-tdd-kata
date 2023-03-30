using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class FibonacciShould
{
    // TODO: Caso 0
    [Test]
    public void ReturnZeroWhenInputIsZero()
    {
        int result = Fibonacci.Calc();
        result.Should().Be(0);
    }
    
    // TODO: Caso 1
    // TODO: Casos n > 1
}