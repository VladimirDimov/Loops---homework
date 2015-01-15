//Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
//Use the Euclidean algorithm (find it in Internet).


using System;
using System.Collections.Generic;
using System.Linq;

class GCD
{
    static void Main()
    {
        Console.WriteLine("Enter first integer:");
        int a = Module(int.Parse(Console.ReadLine()));
        Console.WriteLine("Enter second integer:");
        int b = Module(int.Parse(Console.ReadLine()));

        Console.WriteLine("GCD:");
        Console.WriteLine(gcd(new int[] {a,b}));

        Console.ReadLine();
    }

    static int gcd(int[] x)
    {
        if (x.Min() == 0) return x.Max();
        int remainder = x.Max() % x.Min();
        int[] temp = new int[2];
        temp[0] = x.Min();
        temp[1] = remainder;
        return gcd(temp);
    }

    static int Module(int x)
    {
        if (x<0) return -1 * x;        
        else return x;
    }

}
