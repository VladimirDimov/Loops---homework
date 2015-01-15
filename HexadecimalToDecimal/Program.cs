//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Collections.Generic;
using System.Linq;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter hexadecimal number:");
        char[] input = Console.ReadLine().ToCharArray();
        Array.Reverse(input);
        long decimalValue = 0;

        Dictionary<char, int> hexadecimalDigits = new Dictionary<char, int>();
        hexadecimalDigits.Add('0', 0);
        hexadecimalDigits.Add('1', 1);
        hexadecimalDigits.Add('2', 2);
        hexadecimalDigits.Add('3', 3);
        hexadecimalDigits.Add('4', 4);
        hexadecimalDigits.Add('5', 5);
        hexadecimalDigits.Add('6', 6);
        hexadecimalDigits.Add('7', 7);
        hexadecimalDigits.Add('8', 8);
        hexadecimalDigits.Add('9', 9);
        hexadecimalDigits.Add('A', 10);
        hexadecimalDigits.Add('B', 11);
        hexadecimalDigits.Add('C', 12);
        hexadecimalDigits.Add('D', 13);
        hexadecimalDigits.Add('E', 14);
        hexadecimalDigits.Add('F', 15);

        for (int i = 0; i < input.Length; i++)
        {
            decimalValue = decimalValue + (long)hexadecimalDigits[(char)input[i]] * (long)Math.Pow(16, i);
        }
        Console.WriteLine("Decimal representation:");
        Console.WriteLine(decimalValue);

        Console.ReadLine();
    }
}
