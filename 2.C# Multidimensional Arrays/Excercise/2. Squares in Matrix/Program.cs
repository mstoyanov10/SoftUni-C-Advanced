using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = size[0];

int cols = size[1];

char [,] matrix = new char[rows, cols];

int sequences = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    char[] values = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = values[col];

    }

}

for (int row = 0; row < matrix.GetLength(0) - 1; row++)
{

    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
    {
        
        

     if (matrix[row,col] == matrix[row + 1,col] &&
         matrix[row , col] == matrix[row , col + 1] &&
         matrix[row , col ] == matrix[row + 1, col + 1])
    {

      sequences++;

     }


    }
}

Console.WriteLine(sequences);
