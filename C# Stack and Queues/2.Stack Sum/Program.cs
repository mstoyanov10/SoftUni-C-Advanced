using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Stack_Sum
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            foreach (var num in array)
            {
                stack.Push(num);
            }

            int sum = 0;

            string command = string.Empty;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] data = command.Split(' ');


                if (data[0].ToLower() == "add")
                {
                    int num = int.Parse(data[1]);

                    int num2 = int.Parse(data[2]);

                    stack.Push(num);

                    stack.Push(num2);


                }


                else
                {
                    int count = int.Parse(data[1]);

                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }

                }

            }

            while (stack.Count != 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
