//Write a program to calculate the nth Catalan number by given n (1 < n < 100).

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number n (1 < n < 100):");
        int n = int.Parse(Console.ReadLine());

        BigInteger CatalanNumber = (Factorial(2*n))/(Factorial(n+1)*Factorial(n));

        Console.WriteLine("The n-th Catalan number is:");
        Console.WriteLine(CatalanNumber);
    }

    static BigInteger Factorial(int x)
    {
        BigInteger result;
        if (x == 0) return 1;
        result = x * Factorial(x - 1);
        return result;
    }
}
