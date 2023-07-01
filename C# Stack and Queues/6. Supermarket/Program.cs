


            string command = Console.ReadLine();

            Queue<string> names = new Queue<string>();

            while (command != "End")
            {

                if (command == "Paid")
                {

                    Console.WriteLine(string.Join(Environment.NewLine, names));

                    names.Clear();




                }

                else
                {

                    names.Enqueue(command);

                }

                command = Console.ReadLine();

            }
            Console.WriteLine($"{names.Count} people remaining.");


        