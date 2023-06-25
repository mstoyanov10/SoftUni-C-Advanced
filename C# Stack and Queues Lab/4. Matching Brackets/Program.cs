using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            var stackOfOpenIndexes = new Stack<int>();



            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {

                    stackOfOpenIndexes.Push(i);

                }

                if (expression[i] == ')')
                {
                    int openBracketIndex = stackOfOpenIndexes.Pop();

                    for (int j = openBracketIndex; j <= i; j++)
                    {
                        Console.Write(expression[j]);

                    }

                    Console.WriteLine();
                }


            }


        }
    }
}
