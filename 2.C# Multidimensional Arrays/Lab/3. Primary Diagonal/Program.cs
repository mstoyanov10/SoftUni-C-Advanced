using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

int size = int.Parse(Console.ReadLine());

int [,] matrix = new int [size,size];

int sum = 0;



for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        matrix[row, col] = rowData[col];
        
    }
    
}

for (int i = 0; i < size; i++)
{
    sum += matrix[i, i];
}
Console.WriteLine(sum);


