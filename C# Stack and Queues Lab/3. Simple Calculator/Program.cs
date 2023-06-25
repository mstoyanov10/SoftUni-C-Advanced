using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] array = Console.ReadLine().Split(' ');

            Array.Reverse(array);

            var stack = new Stack<string>(array);

            int sum = int.Parse(stack.Pop());

            while (stack.Count != 0)
            {

                string operation = stack.Pop();


                int number = int.Parse(stack.Pop());

                if (operation == "+")
                {
                    sum += number;

                }
                else if (operation == "-")
                {
                    sum -= number;

                }
                else
                {
                    continue;
                }

            }

            Console.WriteLine(sum);




        }

    }
}

