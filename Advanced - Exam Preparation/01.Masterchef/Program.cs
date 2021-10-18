using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Masterchef
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> freshness = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            //Dictionary<string, int> dishes = new Dictionary<string, int>();
            //dishes.Add("Dipping sauce", 0);
            //dishes.Add("Green salad", 0);
            //dishes.Add("Chocolate cake", 0);
            //dishes.Add("Lobster", 0);
            int[] dishes = new int[4] { 0, 0, 0, 0 };
            while (ingredients.Count > 0 && freshness.Count > 0)
            {
                int totalFreshness = ingredients.Peek() * freshness.Peek();
                if (totalFreshness == 150)
                {
                    dishes[0]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 250)
                {
                    dishes[1]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 300)
                {
                    dishes[2]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (totalFreshness == 400)
                {
                    dishes[3]++;
                    ingredients.Dequeue();
                    freshness.Pop();
                }
                else if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                }
                else
                {
                    freshness.Pop();
                    int tempIngredient = ingredients.Dequeue() + 5;
                    ingredients.Enqueue(tempIngredient);
                }

            }

            if (dishes[0] > 0 && dishes[1] > 0 && dishes[2] > 0 && dishes[3] > 0)
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
                Console.WriteLine($" # Chocolate cake --> {dishes[2]}");
                Console.WriteLine($" # Dipping sauce --> {dishes[0]}");
                Console.WriteLine($" # Green salad --> {dishes[1]}");
                Console.WriteLine($" # Lobster --> {dishes[3]}");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                int ingridientsSum = ingredients.Sum();
                if (ingridientsSum > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingridientsSum}");
                }
                if (dishes[2] > 0)
                {
                    Console.WriteLine($" # Chocolate cake --> {dishes[2]}");
                }
                if (dishes[0] > 0)
                {
                    Console.WriteLine($" # Dipping sauce --> {dishes[0]}");
                }
                if (dishes[1] > 0)
                {
                    Console.WriteLine($" # Green salad --> {dishes[1]}");
                }

                if (dishes[3] > 0)
                {
                    Console.WriteLine($" # Lobster --> {dishes[3]}");
                }
            }
        }
    }
}

