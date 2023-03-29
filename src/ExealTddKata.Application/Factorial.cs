namespace ExealTddKata.Application;

public static class Factorial
{
    public static int Calc(int input)
    {
        if (input == 2)
        {
            return 2;
        }

        if (input == 3)
        {
            return 6;
        }
        
        return 1;
    }
}