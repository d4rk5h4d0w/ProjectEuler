using System;

class Problem1
{
    public static void Main()
    {
        int targetNumber = 1000;
        int sum = 0;

        for(int i = 1; i < targetNumber; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine(sum);
        Console.ReadKey();
    }
}

