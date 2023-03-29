namespace ExealTddKata.Application;

public static class Factorial
{
    public static int Calc(int input)
    {
        int total = 1; 
        for (int number = 1; number <= input; number++)
        {
            total *= number;
        }

        return total;
    }
}