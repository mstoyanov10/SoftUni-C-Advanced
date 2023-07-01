using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Fashion_Boutique
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            var clothes = new Stack<int>(array);

            int racks = 1;

            int currentRack = capacity;



            while (clothes.Count != 0)
            {
                currentRack -= clothes.Peek();

                if (currentRack < 0)
                {
                    currentRack = capacity;

                    racks++;

                    continue;
                }
                
                

              
                    clothes.Pop();


                




            }

            Console.WriteLine(racks);

        
        }
    }
}
