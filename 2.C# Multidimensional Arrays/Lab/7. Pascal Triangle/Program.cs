using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int n = int.Parse(Console.ReadLine());

//1
//1 1
//1 2 1
//1 3 3 1
//1 4 6 4 1   /// 5
//1 5 10 10 5 1 /// 6
//1 6 15 20 15 6 1
//1 7 21 35 35 21 7 1
//1 8 28 56 70 56 28 8 1
//1 9 36 84 126 126 84 36 9 1
//1 10 45 120 210 252 210 120 45 10 1
//1 11 55 165 330 462 462 330 165 55 11 1
//1 12 66 220 495 792 924 792 495 220 66 12 1


long[][] pascal = new long[n][];

pascal[0] = new long[1] { 1 };

for (int row = 1; row < n; row++)
{
    pascal[row] = new long[row + 1];

    for (int col = 0; col < pascal[row].Length; col++)
    {

        if (pascal[row - 1].Length > col)
        {

            pascal[row][col] += pascal[row - 1][col];

        }
        if (col > 0)
        {
            pascal[row][col] += pascal[row - 1][col - 1];


        }

    }

}


for (int row = 0; row < pascal.Length; row++)
{

    for (int col = 0; col < pascal[row].Length; col++)
    {
        Console.Write($"{pascal[row][col]} ");
    }

    Console.WriteLine();

}