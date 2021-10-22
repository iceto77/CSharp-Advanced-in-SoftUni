using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _01.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEffects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> bombCasings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            int daturaBombs = 0;
            int cherryBombs = 0;
            int smokeDecoyBombs = 0;
            bool isCompleted = false;
            while (bombCasings.Count > 0 && bombEffects.Count > 0)
            {
                int effect = bombEffects.Peek();
                int casing = bombCasings.Peek();
                if (effect + casing == 40)
                {
                    daturaBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (effect + casing == 60)
                {
                    cherryBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else if (effect + casing == 120)
                {
                    smokeDecoyBombs++;
                    bombEffects.Dequeue();
                    bombCasings.Pop();
                }
                else
                {
                    bombCasings.Push(bombCasings.Pop() - 5);
                }
                if (daturaBombs >= 3 && cherryBombs >= 3 && smokeDecoyBombs >= 3)
                {
                    isCompleted = true;
                    break;
                }
            }
            if (isCompleted)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            StringBuilder sb = new StringBuilder();
            if (bombEffects.Count > 0)
            {
                sb.Append("Bomb Effects: ");
                sb.AppendJoin(", ", bombEffects);
            }
            else
            {
                sb.AppendLine("Bomb Effects: empty");
            }
            Console.WriteLine(sb.ToString().TrimEnd());
            sb.Clear();
            if (bombCasings.Count > 0)
            {
                sb.Append("Bomb Casings: ");
                sb.AppendJoin(", ", bombCasings);
            }
            else
            {
                sb.AppendLine("Bomb Casings: empty");
            }

            Console.WriteLine(sb.ToString().TrimEnd());
            Console.WriteLine($"Cherry Bombs: {cherryBombs}");
            Console.WriteLine($"Datura Bombs: {daturaBombs}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBombs}");
        }
    }
}
