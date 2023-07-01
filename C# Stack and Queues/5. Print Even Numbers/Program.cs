



            int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(array);

            Queue<int> evens = new Queue<int>();

            while (queue.Count != 0)
            {
                if (queue.Peek() % 2 != 0)
                {
                    queue.Dequeue();


                }
                else
                {

                    evens.Enqueue(queue.Dequeue());
                }


            }

            Console.WriteLine(String.Join(", ", evens));

        