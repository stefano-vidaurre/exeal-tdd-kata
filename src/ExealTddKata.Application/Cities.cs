namespace ExealTddKata.Application;

public class Cities
{
    public IEnumerable<string> Find(string input)
    {
        if (input == "Par")
        {
            return new[] { "Paris" };
        }
        
        return Enumerable.Empty<string>();
    }
}