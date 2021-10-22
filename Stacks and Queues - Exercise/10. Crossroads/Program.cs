using System;
using System.Collections.Generic;
using System.Text;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int totalCarsPassed = 0;
            string input = Console.ReadLine();
            string lastCar = string.Empty;
            StringBuilder nextCar = new StringBuilder();
            while (true)
            {
                if (input == "green")
                {
                    for (int i = 0; i < greenLightDuration; i++)
                    {
                        if (nextCar.Length == 0)
                        {
                            if (cars.Count > 0)
                            {
                                lastCar = cars.Peek();
                                nextCar.Append(cars.Dequeue());
                                totalCarsPassed++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        nextCar.Remove(0, 1);

                    }
                    for (int i = 0; i < freeWindowDuration; i++)
                    {
                        if (nextCar.Length > 0)
                        {
                            nextCar.Remove(0, 1);
                        }
                    }
                    if (nextCar.Length != 0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{lastCar} was hit at {nextCar[0]}.");
                        break;
                    }

                }
                else if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    break;
                }
                else
                {
                    cars.Enqueue(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
