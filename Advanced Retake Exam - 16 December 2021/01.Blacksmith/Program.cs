using System;
using System.Collections.Generic;
using System.Linq;

namespace Blacksmith
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var steel = new Queue<int>();
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                steel.Enqueue(input[i]);
            }
           var carbon = new Stack<int>();
            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                carbon.Push(input[i]);
            }
            var swords = new SortedDictionary<string, int>();
            while (steel.Count > 0 && carbon.Count > 0)
            {
                var currentSword = steel.Peek() + carbon.Peek();
                switch (currentSword)
                {
                    case 70:
                        ChechIsExsist("Gladius", swords);
                        swords["Gladius"]++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 80:
                        ChechIsExsist("Shamshir", swords);
                        swords["Shamshir"]++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 90:
                        ChechIsExsist("Katana", swords);
                        swords["Katana"]++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 110:
                        ChechIsExsist("Sabre", swords);
                        swords["Sabre"]++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    case 150:
                        ChechIsExsist("Broadsword", swords);
                        swords["Broadsword"]++;
                        steel.Dequeue();
                        carbon.Pop();
                        break;
                    default:
                        steel.Dequeue();
                        var newCarbon = carbon.Pop() + 5;
                        carbon.Push(newCarbon);
                        break;
                }
            }
            if (swords.Count == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {

                Console.WriteLine($"You have forged {swords.Sum(x => x.Value)} swords.");
            }
            if (steel.Count == 0)
            {
                Console.WriteLine("Steel left: none");
            }
            else
            {
                Console.WriteLine($"Steel left: {string.Join(", ", steel)}");
            }
            if (carbon.Count == 0)
            {
                Console.WriteLine("Carbon left: none");
            }
            else
            {
                Console.WriteLine($"Carbon left: {string.Join(", ", carbon)}");
            }
            foreach (var item in swords)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }

        private static void ChechIsExsist(string sword, SortedDictionary<string, int> swords)
        {
            if (!swords.ContainsKey(sword))
            {
                swords.Add(sword, 0);
            }
        }
    }
}
