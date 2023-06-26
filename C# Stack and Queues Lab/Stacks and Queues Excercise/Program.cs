using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace Stacks_and_Queues_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string command = "Pederas";

            int lastIndex = command.Length - 1;

            command = command.Remove(lastIndex, lastIndex - 1);

            Console.WriteLine(command);



        }
    }
}
