using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace _03._Maximum_and_Minimum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var stack = new Stack<int>();

            int queries = int.Parse(Console.ReadLine());

            int biggest = int.MinValue;

            int smallest = int.MaxValue;

            for (int i = 0; i < queries; i++)
            {
                int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    int number = command[1];

                    stack.Push(number); 

                }
                else if (command[0] == 2)
                {
                    stack.Pop();
                }

               else if (command[0] == 3)
               {
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    foreach (var item in stack)
                    {
                        if (item > biggest)
                        {
                            biggest = item;
                        }
                    }
                    Console.WriteLine(biggest);

               }

               else
               {
                    if (stack.Count == 0)
                    {
                        continue;
                    }

                    foreach (var item in stack)
                    {
                        if (item < smallest)
                        {
                            smallest = item;
                        }
                    }
                    Console.WriteLine(smallest);

                }
            }

            Console.WriteLine(String.Join(", " , stack));





        }
    }
}
