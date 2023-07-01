using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Basic_Queue_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int enqueues = commands[0];

            int dequeues = commands[1];

            int X = commands[2];    

            int [] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            int smallest = int.MaxValue;

            for (int i = 0; i < enqueues; i++)
            {
                queue.Enqueue(array[i]);

            }
            for (int i = 0; i < dequeues; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
            }
            else if (queue.Contains(X))
                
            {
                Console.WriteLine("true");

            }
            else
            {
                foreach (var number in queue)
                {
                    if (number < smallest)
                    {
                        smallest = number;
                    }
                }
                Console.WriteLine(smallest);
            }
        }
    }
}
