using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Fast_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var orders = new Queue<int>(array);

            int biggest = orders.Max();

            Console.WriteLine(biggest);

            bool fail = false;

            for (int i = 0; i < array.Length; i++)
            {
                int portion = array[i];

                if (portion > quantity)
                {
                    fail = true;
                    break;
                }
                else
                {
                    
                    quantity -= portion;
                    orders.Dequeue();

                }


            }
            if (!fail)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {(string.Join(' ', orders))}");
            }
        }
    }
}
