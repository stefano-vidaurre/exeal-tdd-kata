namespace ExealTddKata.Application;

public static class PasswordValidator
{
    public static (bool, string) Validate(string pass)
    {
        return (false, "Password must be at least 8 characters");
    }
}