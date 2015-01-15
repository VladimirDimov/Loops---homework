//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Enter integer number:");
        uint n = uint.Parse(Console.ReadLine());
        byte[] factorial = Factorial(n).ToString().ToCharArray().Select(t => (byte)char.GetNumericValue(t)).ToArray();
        Array.Reverse(factorial);
        uint zeroCounter = 0;

        for (int i = 0; i < factorial.Length; i++)
        {

            if (factorial[i] == 0)
            {
                zeroCounter++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine("trailing zeroes of n!");
        Console.WriteLine(zeroCounter);
        Console.ReadLine();
    }

    static BigInteger Factorial(uint x)
    {
        BigInteger result = x;
        while (x != 1)
        {
            if (x != 0)
            {
                result = result * (x - 1);
            }
            x--; 
        }
        return result;
    }
}
