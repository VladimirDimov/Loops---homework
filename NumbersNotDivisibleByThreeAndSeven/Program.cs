//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n 
//not divisible by 3 and 7, on a single line, separated by a space.

using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        bool isDevisibleByThreeAndSeven;

        for (int i = 1; i <= n; i++)
        {
            isDevisibleByThreeAndSeven = (i % 3 == 0) || (i % 7 == 0);

            if (!isDevisibleByThreeAndSeven)
            {
                Console.Write("{0} ", i);
            }
        }
        Console.ReadLine();
    }
}
