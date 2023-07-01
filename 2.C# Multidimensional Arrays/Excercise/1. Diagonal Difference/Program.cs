using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int size = int.Parse(Console.ReadLine());

int[,] matrix = new int[size, size];

int primary = 0;

int secondary = 0;

for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] values = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {

        matrix[row,col] = values[col];


    }


}

for (int i = 0; i < size; i++)
{
    primary += matrix[i, i];
    secondary += matrix[size - i - 1, i];
}

Console.WriteLine(Math.Abs(primary - secondary));