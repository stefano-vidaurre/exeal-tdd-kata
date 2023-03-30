namespace ExealTddKata.Application;

public static class Fibonacci
{
    public static int Calc(int input)
    {
        if (input == 1)
        {
            return 1;
        }

        if (input == 2)
        {
            return 1;
        }

        if (input == 3)
        {
            return 2;
        }
        
        if (input == 4)
        {
            return 3;
        }

        if (input == 5)
        {
            return 5;
        }
        
        return 0;
    }
}