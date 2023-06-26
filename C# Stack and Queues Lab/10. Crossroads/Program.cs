using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


int greenLightSeconds = int.Parse(Console.ReadLine());

int freeWindowDuration = int.Parse(Console.ReadLine());


string command = string.Empty;

int passedCars = 0;


Queue<string> cars = new();

while ((command = Console.ReadLine()) != "END")
{
    if (command != "green")
    {
        cars.Enqueue(command);
        continue;
    }

    int currentGreenLight = greenLightSeconds;

    while (currentGreenLight > 0 && cars.Any())
    {

     string currentCar = cars.Dequeue();

        if (currentGreenLight - currentCar.Length >= 0)
        {

            currentGreenLight -= currentCar.Length;

            passedCars++;

            continue;
        }
        if (currentGreenLight + freeWindowDuration - currentCar.Length >= 0) 
        {


            passedCars++;

            continue;


        }

        int hittedChar = currentGreenLight + freeWindowDuration;
        Console.WriteLine($"A crash happened!");
        Console.WriteLine($"{currentCar} was hit at {currentCar[hittedChar]}.");

        return; 

    }




}



Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{passedCars} total cars passed the crossroads.");






