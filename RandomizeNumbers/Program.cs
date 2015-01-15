//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


class RandomizeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter range upper limit:");
        int rangeMax = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int randomIndex = 0;
        List<int> listOfNumbers = new List<int>();

        int temp = 0;

        for (int i = 1; i <= rangeMax; i++)
        {
            listOfNumbers.Add(i);
        }

        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            temp = listOfNumbers[i];                     
            randomIndex = rnd.Next(0, listOfNumbers.Count);
            listOfNumbers[i] = listOfNumbers[randomIndex];
            listOfNumbers[randomIndex] = temp;
        }

        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            Console.Write("{0} ", listOfNumbers[i]);
        }
        Console.ReadLine();
    }
}
