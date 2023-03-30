namespace ExealTddKata.Application;

public static class PasswordValidator
{
    public static (bool, string) Validate(string pass)
    {
        IList<string> errors = new List<string>();
        
        if (pass.Length < 8)
        {
            errors.Add("Password must be at least 8 characters");
        }

        if (pass.Count(char.IsDigit) < 2)
        {
            errors.Add("Password must contain at least 2 numbers");
        }
        
        return (errors.Count == 0, PrintErrorMessage(errors));
    }

    private static string PrintErrorMessage(IList<string> errors)
    {
        return errors.Aggregate("", (acc, next) => acc += PrintNextMessage(acc, next));
    }

    private static string PrintNextMessage(string acc, string next)
    {
        if (string.IsNullOrEmpty(acc))
        {
            return next;
        }
        
        return $"\n{next}";
    }
}