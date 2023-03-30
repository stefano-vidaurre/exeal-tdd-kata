namespace ExealTddKata.Application;

public static class PasswordValidator
{
    public static (bool, string) Validate(string pass)
    {
        if (pass.Length < 8)
        {
            return (false, "Password must be at least 8 characters");
        }

        return (false, "Password must contain at least 2 numbers");
    }
}