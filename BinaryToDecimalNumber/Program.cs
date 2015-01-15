//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;


class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.WriteLine("Enter binary number:");
        int[] binaryToArray = Console.ReadLine().ToCharArray().Select(n => (int)char.GetNumericValue(n)).ToArray();
        Array.Reverse(binaryToArray);

        int decimalNumber = 0;

        for (int i = 0; i < binaryToArray.Length; i++)
        {
            decimalNumber += binaryToArray[i] * (int)Math.Pow(2, i);
        }
        Console.WriteLine("Decimal form:");
        Console.WriteLine(decimalNumber);    

        Console.ReadLine();
    }
}
