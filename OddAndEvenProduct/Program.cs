//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n , so the first element is odd, the second is even, etc.

using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter integers, separated by a space:");
        int[] integers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(n => int.Parse(n)).ToArray();
        int oddProduct = 1;
        int evenProduct = 1;

        for (int i = 0; i < integers.Length; i++)
        {
            bool isEven = i % 2 != 0;

            if (isEven)
            {
                evenProduct *= integers[i];
            }
            else
            {
                oddProduct *= integers[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.ReadLine();
    }
}
