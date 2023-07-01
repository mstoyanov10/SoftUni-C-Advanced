using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

string parentheses = Console.ReadLine();

Stack <char> stack = new();


foreach (char parenthes in parentheses)
{
    switch (parenthes)
    {

        case '(':
        case '[':
        case '{':
            stack.Push(parenthes);
            break;
            case ')':
            if (stack.Count == 0 || stack.Pop() != '(')
            {
                Console.WriteLine("NO");
                return;
            }
            break;
        case ']':
            if (stack.Count == 0 || stack.Pop() != '[')
            {
                Console.WriteLine("NO");
                return;

            }
            break;
        case '}':
            if (stack.Count == 0 || stack.Pop() != '{')
            {
                Console.WriteLine("NO");
                return;
            }
            break;

    }
}

if (stack.Count != 0)
{

    Console.WriteLine("NO");

}
else
{
    Console.WriteLine("YES");

}







