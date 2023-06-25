

            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char character in input)
            {
                stack.Push(character);

            }

            while (stack.Count != 0)
            {

                Console.Write(stack.Pop());
            }

        
