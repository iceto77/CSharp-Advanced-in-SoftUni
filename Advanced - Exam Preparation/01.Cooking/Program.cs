using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            int bread = 0;
            int cake = 0;
            int fruit = 0;
            int pastry = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currentIngredient = ingredients.Peek();
                int cookDelicacies = liquids.Dequeue() + ingredients.Pop();
                if (cookDelicacies == 25)
                {
                    bread++;
                }
                else if (cookDelicacies == 50)
                {
                    cake++;
                }
                else if (cookDelicacies == 75)
                {
                    pastry++;
                }
                else if (cookDelicacies == 100)
                {
                    fruit++;
                }
                else
                {
                    ingredients.Push(currentIngredient + 3);
                }
            }
            if (bread > 0 && cake > 0 && fruit > 0 && pastry > 0)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
            if (liquids.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Liquids left: ");
                sb.Append(string.Join(", ", liquids));
                Console.WriteLine(sb.ToString().TrimEnd());
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }
            if (ingredients.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Ingredients left: ");
                sb.Append(string.Join(", ", ingredients));
                Console.WriteLine(sb.ToString().TrimEnd());
            }
            else
            {
                Console.WriteLine("Ingredients left: none");
            }
            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruit}");
            Console.WriteLine($"Pastry: {pastry}");
        }
    }
}
