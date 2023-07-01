using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();



int rows = array[0];

int cols = array[1];

int [,] matrix = new int[rows, cols];



for (int row = 0; row < matrix.GetLength(0); row++)
{
    int[] rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    for (int col = 0; col < matrix.GetLength(1); col++)
    {
       
        matrix[row, col] = rowData[col];
        
    }

}

Console.WriteLine(rows);
Console.WriteLine(cols);





 

