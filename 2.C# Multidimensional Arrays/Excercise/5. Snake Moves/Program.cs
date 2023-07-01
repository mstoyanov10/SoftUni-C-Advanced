using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;



int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = sizes[0];

int cols = sizes[1];

string word = Console.ReadLine();

int [,] matrix = new int[rows, cols];

int currentWordIndex = 0;

for (int row = 0; row < rows; row++)
{
    if (row % 2 == 0)
    {
        for (int col = 0; col < cols; col++)
        {
            if (currentWordIndex == word.Length)
            {
                currentWordIndex = 0;

            }

            currentWordIndex++;


        }
    }

    else
    {
        for (int col = cols - 1; col >= 0; col--)
        {
            if (currentWordIndex == word.Length)
            {
                currentWordIndex = 0;

            }

            currentWordIndex++;

        }


    }
    for (int r = 0; r < rows; r++)
    {
        for (int col = 0; col < cols; col++)
        {
            Console.Write($"{matrix[r, col]} ");
        }

        Console.WriteLine();
    }


}