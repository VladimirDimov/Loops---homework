//In combinatorics, the number of ways to choose k different members out of a group of n different elements
//(also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways
//to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
//Try to use only two loops.

using System;
using System.Numerics;

class NumberOfCombinations
{
    static void Main()
    {
        Console.WriteLine("Enter number of all the elements n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter number of group elements k:");
        int k = int.Parse(Console.ReadLine());

        BigInteger numberOfCombinations = Factorial(n) / (Factorial(k) * Factorial(n - k));

        Console.WriteLine("The number of combinations is:");
        Console.WriteLine(numberOfCombinations);
        Console.ReadLine();
    }

    static BigInteger Factorial(int x)
    {
        BigInteger result;
        if (x == 0) return 1;
        result = x * Factorial(x - 1);

        return result;
    }
}
