using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = sizes[0];

int cols = sizes[1];

string [,] matrix = new string[rows, cols];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    string [] data = Console.ReadLine().Split(' ');

    for (int col = 0; col < matrix.GetLength(1); col++)
    {

        matrix[row, col] = data[col];
    }
}

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")

{
    string[] Args = command.Split(' ');

    if (Args[0] != "swap" && Args.Length != 5)
    {

        Console.WriteLine("Invalid input!");
        continue;
    }
    int row1 = int.Parse(Args[1]);
    int col1 = int.Parse(Args[2]);
    int row2 = int.Parse(Args[3]);
    int col2 = int.Parse(Args[4]);

    if (row1 >= matrix.GetLength(0) || row1 < 0
        || row2 >= matrix.GetLength(0) || row2 < 0
        || col1 >= matrix.GetLength(1) || col1 < 0
        || col2 >= matrix.GetLength(1) || col2 < 0)

    {

        Console.WriteLine("Invalid input!");
        continue;

    }

    string input = matrix[row1, col1];
    matrix[row1, col1] = matrix[row2, col2];

    matrix[row2, col2] = input;

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write($"{matrix[row,col]} "); ;
          
        }

        Console.WriteLine();
    }
}

