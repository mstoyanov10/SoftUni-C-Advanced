using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = sizes[0];

int cols = sizes[1];

int [,] matrix = new int [rows, cols];


for (int row = 0; row < matrix.GetLength(0); row++)
{
    int [] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {

        matrix[row, col] = data[col];


    }


}

int sum = 0;

int bestSum = 0;

int maxSumRow = 0;

int maxSumCol = 0;


for (int row = 0; row < matrix.GetLength(0) - 2; row++)
{


    for (int col = 0; col < matrix.GetLength(1) - 2; col++)
    {
        sum = 0;
        sum += matrix[row, col];
        sum += matrix[row + 1, col];
        sum += matrix[row + 2, col];
        sum += matrix[row, col + 1];
        sum += matrix[row, col + 2];
        sum += matrix[row + 1, col + 1];
        sum += matrix[row + 2, col + 1];
        sum += matrix[row + 1, col + 2];
        sum += matrix[row + 2, col + 2];

        if (sum > bestSum)
        {
            bestSum = sum;

            maxSumRow = row;

            maxSumCol = col;


        }

    }

}

Console.WriteLine($"Sum = {sum}");


for (int row = maxSumRow; row < maxSumRow + 3; row++)
{
    for (int col = maxSumCol; col < maxSumCol + 3; col++)
    {

        Console.Write(matrix[row,col] + " ");

    }


    Console.WriteLine();

}




