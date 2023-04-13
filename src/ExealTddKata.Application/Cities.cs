namespace ExealTddKata.Application;

public class Cities
{
    public IEnumerable<string> Find(string input)
    {
        if (input == "Pa")
        {
            return new[] { "Paris" };
        }
        
        if (input == "Va")
        {
            return new[] { "Valencia" };
        }
        
        if (input == "Bu")
        {
            return new[] { "Budapest" };
        }
        
        return Enumerable.Empty<string>();
    }
}