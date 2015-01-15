//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        string hexadecimalRepresentation = null;

        Dictionary<long, char> hexadecimalDigits = new Dictionary<long, char>();
        hexadecimalDigits.Add(0, '0');
        hexadecimalDigits.Add(1, '1');
        hexadecimalDigits.Add(2, '2');
        hexadecimalDigits.Add(3, '3');
        hexadecimalDigits.Add(4, '4');
        hexadecimalDigits.Add(5, '5');
        hexadecimalDigits.Add(6, '6');
        hexadecimalDigits.Add(7, '7');
        hexadecimalDigits.Add(8, '8');
        hexadecimalDigits.Add(9, '9');
        hexadecimalDigits.Add(10, 'A');
        hexadecimalDigits.Add(11, 'B');
        hexadecimalDigits.Add(12, 'C');
        hexadecimalDigits.Add(13, 'D');
        hexadecimalDigits.Add(14, 'E');
        hexadecimalDigits.Add(15, 'F');

        while (input != 0)
        {
            int remainder = (int)(input % 16);
            hexadecimalRepresentation = hexadecimalDigits[remainder] + hexadecimalRepresentation;
            input = input / 16;
        }
        Console.WriteLine(hexadecimalRepresentation);
        Console.ReadLine();
    }
}
