using System;

class Problem3
{
    static void Main()
    {
        long targetNumber = 600851475143, factor = 1;
        string primeFactors = "1";

        Problem3 prime = new Problem3();
        
        for( long i = 2; i <= Math.Sqrt(targetNumber); i++)
        {
            if (targetNumber % ((2 * i) - 1) == 0)
            {
                factor = ((2 * i) - 1);
                if (prime.PrimeNumber(factor))
                    primeFactors = primeFactors + " , " + factor.ToString();
            }
        }
        
        Console.WriteLine(primeFactors);
        Console.ReadKey();
    }

    public bool PrimeNumber(long Number)
    {
        long i = 2;
        bool prime = false;
        long flag = 1;

        while (i < Number)
        {
            if (Number % i == 0)
            {
                prime = false;
                break;
            }
            else if (Number % i != 0)
            {
                flag = i;
                i++;
            }
        }

        if(flag == (Number - 1))
            prime = true;
        
        return (prime);
    }
}

