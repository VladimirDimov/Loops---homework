//Write a program that enters 3 integers n , min and max ( min = max ) and prints n random numbers in the range
//[min...max] .

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Enter number of random numbers:");
        int numberOfRandomNumbers = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter range down limit:");
        int rangeMin = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter range upper limit:");
        int rangeMax = int.Parse(Console.ReadLine());
        
        Random randomNumber = new Random();

        for (int i = 0; i < numberOfRandomNumbers; i++)
        {
            Console.Write("{0} ", randomNumber.Next(rangeMin, rangeMax+1));
        }



        Console.ReadLine();
    }
}
