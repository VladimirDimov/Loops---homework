//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.


using System;
using System.Collections.Generic;
using System.Linq;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long numberDecimal = long.Parse(Console.ReadLine());
        if (numberDecimal == 0)
        {
            Console.WriteLine("0");
        }
        string tempString = null;

        while (numberDecimal != 0)
        {
            tempString = (numberDecimal % 2).ToString() + tempString;
            numberDecimal = numberDecimal / 2;
        }

        Console.WriteLine(tempString);
        Console.ReadLine();
    }
}
