//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("Insert N:");
        uint N = uint.Parse(Console.ReadLine());
        Console.WriteLine("Write down all the numbers on separate line...");

        List<int> numbers = new List<int>();

        
        for (int i = 0; i < N; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        int min = numbers.Min();
        int max = numbers.Max();
        int sum = numbers.Sum();
        double average = numbers.Average();

        Console.WriteLine("min={0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum={0}", sum);
        Console.WriteLine("avg={0:0.00}", average);

        Console.ReadLine();
    }
}
