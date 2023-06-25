

            string[] names = Console.ReadLine().Split(' ');

            int allowedSteps = int.Parse(Console.ReadLine());

            int stepsPassed = 1;

            Queue<string> players = new Queue<string>(names);

            while (players.Count != 1)
            {
                string name = players.Dequeue();

                if (stepsPassed < allowedSteps)
                {

                    stepsPassed++;
                    players.Enqueue(name);
                }

                else
                {
                    Console.WriteLine($"Removed {name}");
                    stepsPassed = 1;
                }



            }
            Console.WriteLine($"Last is {players.Dequeue()}");

        