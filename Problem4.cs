using System;

class Problem4
{
    static void Main()
    {
        long number, largestPalindrome = 0;

        Problem4 palindrome = new Problem4();

        for(long i = 999; i > 99; i--)
        {
            for(long j = 999; j > 99; j--)
            {
                number = i * j;
                if(palindrome.PalindromicNumber(number) && 
                        number > largestPalindrome)
                {
                    largestPalindrome = number;
                }
            }
        }

        Console.WriteLine(largestPalindrome);
        Console.ReadKey();
    }

    public long ReverseNumber(long number)
    {
        long reverseNumber = 0;

        while(number > 0)
        {
            reverseNumber = ((reverseNumber * 10) + (number % 10));
            number = number / 10;
        }
        
        return(reverseNumber);
    }

    public bool PalindromicNumber(long number)
    {
        bool palindromic = false;
        Problem4 reverse = new Problem4();
        long reverseNumber = reverse.ReverseNumber(number);
        
        if(number == reverseNumber)
            palindromic = true;

        return(palindromic);
    }
}
