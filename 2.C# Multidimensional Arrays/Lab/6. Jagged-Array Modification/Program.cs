using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;















//3
//1 2 3
//4 5 6 7
//8 9 10



int rowsCount = int.Parse(Console.ReadLine());

int[][] jaggedArray = new int[rowsCount][];


for (int row = 0; row < rowsCount; row++)
{

    jaggedArray[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

}

string command = string.Empty;

 


while (( command = Console.ReadLine())!= "END")
{

    string[] Args = command.Split(' ');

    int row = int.Parse(Args[1]);

    int col = int.Parse(Args[2]);

    int value = int.Parse(Args[3]);

    if (row < 0 || row >= jaggedArray.Length || col < 0 || col >= jaggedArray[row].Length)
    {

        Console.WriteLine("Invalid coordinates");



    }

    else
    {

        if (Args[0] == "Add")
        {

            jaggedArray[row][col] += value;


        }
        else
        {

            jaggedArray[row][col] -= value;

        }


    }

    

}




for (int row = 0; row < jaggedArray.Length; row++)
{

    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write($"{jaggedArray[row][col]} ");
    }

    Console.WriteLine();

}