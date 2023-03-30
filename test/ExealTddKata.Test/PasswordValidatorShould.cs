using ExealTddKata.Application;
using FluentAssertions;

namespace ExealTddKata.Test;

public class PasswordValidatorShould
{
    // TODO: Mayor de 8 caracters
    [Test]
    public void ReportCharactersLongError()
    {
        (bool, string) result = PasswordValidator.Validate("");
        result.Should().Be((false, "Password must be at least 8 characters"));
    }
    // TODO: Al menos 2 numeros
    // TODO: Detectar multiples errores
    // TODO: Al menos 1 mayuscula
    // TODO: Al menos 1 caracter especial
}