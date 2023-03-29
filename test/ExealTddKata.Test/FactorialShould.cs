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
}