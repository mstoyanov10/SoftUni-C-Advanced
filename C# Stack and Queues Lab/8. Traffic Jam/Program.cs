
   

            int n = int.Parse(Console.ReadLine());

            string command = string.Empty;

            var queue = new Queue<string>();


            int moves = 0;


            while ((command = Console.ReadLine()) != "end")
            {

                if (command == "green")
                {



                    for (int i = 0; i < n; i++)
                    {

                        if (queue.Count == 0)
                        {

                            break;
                        }

                        moves++;
                        Console.WriteLine($"{queue.Dequeue()} passed!");

                    }


                }

                else
                {


                    queue.Enqueue(command);

                }




            }

            Console.WriteLine($"{moves} cars passed the crossroads.");
