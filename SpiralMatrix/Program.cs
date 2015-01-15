//Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix holding the numbers 
//from 1 to n*n in the form of square spiral like in the examples below.

using System;
using System.Collections.Generic;
using System.Linq;

class SpiralMatrix
{
    static void Main()
    {
        //matrix[row, col]
        Console.WriteLine("Enter the size ofthe matrix:");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        const string left = "left";
        const string right = "right";
        const string up = "up";
        const string down = "down";
        int row = 0;
        int nextRow = 0;
        int col = 0;
        int nextCol = 0;

        string direction = right;

        for (int i = 1; i <= matrixSize*matrixSize; i++)
        {
            matrix[row, col] = i;

            if (direction == right)
            {
                nextCol = col + 1;
                if (nextCol==matrixSize || matrix[row,nextCol] != 0)
                {
                    row++;
                    direction = down;
                }
                else
                {
                    col++;
                }
            }
            else if (direction == down)
            {
                nextRow = row + 1;
                if (nextRow == matrixSize || matrix[nextRow,col] != 0)
                {
                    col--;
                    direction = left;
                }
                else
                {
                    row++;
                }
            }
            else if (direction == left)
            {
                nextCol = col - 1;
                if (nextCol < 0 || matrix[row,nextCol] != 0)
                {
                    row--;
                    direction = up;
                }
                else
                {
                    col--;
                }
            }
            else if (direction == up)
            {
                nextRow = row - 1;
                if (nextRow < 0 || matrix[nextRow,col] != 0)
                {
                    col++;
                    direction = right;
                }
                else
                {
                    row--;
                }
            }
        }

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < matrixSize; j++)
            {
                Console.Write("{0,4}",matrix[i,j]);
            }
            Console.Write("\n");
        }

        Console.ReadLine();
    }
}
