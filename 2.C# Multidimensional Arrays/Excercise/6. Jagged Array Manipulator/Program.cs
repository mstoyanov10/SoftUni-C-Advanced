
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int rows = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rows][];


for (int row = 0; row < jaggedArray.Length; row++)
{

    int[] data = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    jaggedArray[row] = data;


    for (int col = 0; col < jaggedArray[row].Length; col++)
    {

        jaggedArray[row][col] = data[col];

    }


}
for (int row = 0; row < jaggedArray.Length - 1; row++)
{

    if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] *= 2;
            jaggedArray[row + 1][col] *= 2;

        }

    }
    else
    {
        for (int col = 0; col < jaggedArray[row].Length; col++)
        {
            jaggedArray[row][col] /= 2;
            

        }

        for (int col = 0; col < jaggedArray[row + 1].Length; col++)
        {
            jaggedArray[row + 1][col] /= 2;


        }


    }
}

string command = string.Empty;





while ((command = Console.ReadLine()) != "End")
{
    string[] Args = Console.ReadLine().Split(' ');

    string operation = Args[0];

    int rowCoordinate = int.Parse(Args[1]);

    int colCoordinate = int.Parse(Args[2]);

    int value = int.Parse(Args[3]);



    if (operation == "Add")
    {
        if (rowCoordinate < 0 || rowCoordinate >= jaggedArray.Length)
        {
            continue;

        }
        if (colCoordinate < 0 || colCoordinate >= jaggedArray[rowCoordinate].Length)
        {

            continue;

        }



        jaggedArray[rowCoordinate][colCoordinate] += value;


    }

    else
    {

        if (rowCoordinate < 0 || rowCoordinate >= jaggedArray.Length)
        {
            continue;

        }
        if (colCoordinate < 0 || colCoordinate >= jaggedArray[rowCoordinate].Length)
        {

            continue;

        }



        jaggedArray[rowCoordinate][colCoordinate] -= value;


    }


}

for (int row = 0; row < jaggedArray.Length; row++)
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {

        Console.Write(jaggedArray[row][col] + " ");

    }

    Console.WriteLine();
}











