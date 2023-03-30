using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class PasswordValidatorShould
{
    [Test]
    public void ReportCharactersLongError()
    {
        (bool, string) result = PasswordValidator.Validate("1234567");
        result.Should().Be((false, "Password must be at least 8 characters"));
    }
    
    [Test]
    public void ReportNumbersError()
    {
        (bool, string) result = PasswordValidator.Validate("asdfghjk");
        result.Should().Be((false, "Password must contain at least 2 numbers"));
    }

    [Test]
    public void ReportCharAndNumberError()
    {
        (bool, string) result = PasswordValidator.Validate("adad");
        result.Should().Be((false, "Password must be at least 8 characters\nPassword must contain at least 2 numbers"));
    }
    // TODO: Al menos 1 mayuscula
    // TODO: Al menos 1 caracter especial
}