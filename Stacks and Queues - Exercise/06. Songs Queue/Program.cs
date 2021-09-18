using System;
using System.Collections.Generic;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] songs = input.Split(", ");
            Queue<string> songsQueue = new Queue<string>();
            foreach (var item in songs)
            {
                songsQueue.Enqueue(item);
            }
            input = Console.ReadLine();
            while (songsQueue.Count > 0)
            {
                string[] command = new string[2];
                if (input.Contains(' '))
                {
                    int startIndex = input.IndexOf(' ');
                    command[0] = input.Substring(0, startIndex);
                    command[1] = input.Substring(startIndex + 1);
                }
                else
                {
                    command[0] = input;
                }
                switch (command[0])
                {
                    case "Play":
                        songsQueue.Dequeue();
                        break;
                    case "Add":
                        if (songsQueue.Contains(command[1]))
                        {
                            Console.WriteLine($"{command[1]} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(command[1]);
                        }

                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songsQueue));
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
