using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            int pushes = commands[0];

            int pops = commands[1];

            int number = commands[2];

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            int smallest = int.MaxValue;


            for (int i = 0; i < pushes; i++)
            {
                

                  stack.Push(array[i]);

                
            }

            for (int i = 0; i < pops; i++)
            {
                

              stack.Pop();

                
            }

            if (stack.Count == 0)
            {

                Console.WriteLine(stack.Count);
            }

            else if (stack.Contains(number))
            {

                Console.WriteLine("true");


            }

            else
            {
                foreach (int element in stack)
                {
                    int currentNumber = element;

                    if (currentNumber < smallest)
                    {
                        smallest = currentNumber;

                    }

                }
                Console.WriteLine(smallest);
            }

        }
    }
}
