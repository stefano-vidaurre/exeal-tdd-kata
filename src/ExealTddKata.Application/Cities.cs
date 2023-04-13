namespace ExealTddKata.Application;

public class Cities
{
    private readonly string[] _cities;

    public Cities()
    {
        _cities = new[]
        {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valencia", "Vancouver", "Amsterdam", "Vienna", "Sydney",
            "New York City", "London", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul"
        };
    }

    public IEnumerable<string> Find(string input)
    {
        if (input.Length < 2)
        {
            return Enumerable.Empty<string>();
        }

        return _cities.Where(city => city.StartsWith(input));
    }
}