namespace ExealTddKata.Application;

public static class Fibonacci
{
    public static int Calc(int input)
    {
        if (input == 0)
        {
            return 0;
        }
        
        if (input == 1)
        {
            return 1;
        }
        
        return Calc(input - 1) + Calc(input - 2);
    }
}