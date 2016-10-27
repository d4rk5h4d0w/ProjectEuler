using System;

class Problem6
{
    static void Main()
    {
        int number = 100;
        long sumOfSquares, squareOfSum;

        Problem6 obj = new Problem6();
        sumOfSquares = obj.SumOfSquares(number);
        squareOfSum = obj.SquareOfSum(number);

        long difference = squareOfSum - sumOfSquares;

        Console.WriteLine(difference);
        Console.ReadKey();
    }

    public long SumOfSquares(int number)
    {
        long sum = 0;
        for (int i = 1; i <= number; i++)
        {
            sum = sum + (i * i);
        }

        return(sum);
    }

    public long SquareOfSum(int number)
    {
        long sum = 0, square = 0;
        for (int i = 1; i <= number; i++)
        {
            sum = sum + i;
        }
        square = sum * sum;

        return(square);
    }
}
