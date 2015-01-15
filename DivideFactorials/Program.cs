//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Numerics;

class DivideFactorials
{
    static void Main()
    {
        Console.WriteLine("Insert integer n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Insert integer k:");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine(Factorial(n)/Factorial(k));

        Console.ReadLine();
    }

    static BigInteger Factorial(int x)
    {
        BigInteger result;
        if (x==0)
        {
            return 1;
        }
        result = x * Factorial(x - 1);

        return result;
    }
}
