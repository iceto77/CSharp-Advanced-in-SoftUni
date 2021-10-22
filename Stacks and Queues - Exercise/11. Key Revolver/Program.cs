using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int intelligenceValue = int.Parse(Console.ReadLine());
            int bulletCount = 0;
            while (true)
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                bulletCount++;
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletCount % gunBarrelSize == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                }
                if (bullets.Count == 0 && locks.Count > 0)
                {
                    Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                    break;
                }
                if (locks.Count == 0)
                {
                    int moneyEarned = intelligenceValue - (bulletCount * bulletPrice);
                    Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
                    break;
                }
            }
        }
    }
}
