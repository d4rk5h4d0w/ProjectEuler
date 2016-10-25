using System;

class Problem2
{
    static void Main()
    {
        long sum = 0;
        long newTerm = 0;

        long baseTerm = 0, addedTerm = 1;

        while (newTerm < 4000000)
        {
            if (newTerm % 2 == 0)
               sum = sum + newTerm; 

            newTerm = baseTerm + addedTerm;
            baseTerm = addedTerm;
            addedTerm = newTerm;
        }

        Console.WriteLine(sum);
        Console.ReadKey();
    }
}
