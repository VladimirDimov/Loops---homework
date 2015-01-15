//Write a program that, for a given two integer numbers n and x, calculates the sum 
//S = 1 + 1!/x + 2!/x2 + … + n!/xn.
//Use only one loop. Print the result with 5 digits after the decimal point.


using System;
using System.Numerics;

class FactorialSequence
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        uint n = uint.Parse(Console.ReadLine());

        Console.WriteLine("Enter number x:");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum = sum + (double)Factorial(i) / Math.Pow(x, i);
        }

        Console.WriteLine("{0:0.00000}",sum);

        Console.ReadLine();
    }

    static BigInteger Factorial(int number)
    {
        BigInteger result = 1;
        if (number == 0)
        {
            return 1;
        }
        result = number * Factorial(number - 1);
        return result;
    }
}
