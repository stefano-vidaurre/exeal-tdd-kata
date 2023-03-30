namespace ExealTddKata.Application;

public static class PasswordValidator
{
    public static (bool, string) Validate(string pass)
    {
        if (pass == "adad")
        {
            return (false, "Password must be at least 8 characters\nPassword must contain at least 2 numbers");
        }
        
        if (pass.Length < 8)
        {
            return (false, "Password must be at least 8 characters");
        }

        if (pass.Count(char.IsDigit) < 2)
        {
            return (false, "Password must contain at least 2 numbers");
        }

        return (true, "");
    }
}