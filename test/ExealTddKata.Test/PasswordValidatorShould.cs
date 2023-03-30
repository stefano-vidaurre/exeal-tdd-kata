using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class PasswordValidatorShould
{
    [Test]
    public void ReportCharactersLongError()
    {
        (bool, string) result = PasswordValidator.Validate("");
        result.Should().Be((false, "Password must be at least 8 characters"));
    }
    
    // TODO: Al menos 2 numeros
    [Test]
    public void ReportNumbersError()
    {
        (bool, string) result = PasswordValidator.Validate("asdfghjk");
        result.Should().Be((false, "Password must contain at least 2 numbers"));
    }
    // TODO: Detectar multiples errores
    // TODO: Al menos 1 mayuscula
    // TODO: Al menos 1 caracter especial
}