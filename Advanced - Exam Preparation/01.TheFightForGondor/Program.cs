using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> plates = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Stack<int> orcs = new Stack<int>();

            int wavesCount = 1;
            int orcPower = 0;
            int wallPower = 0;
            while (wavesCount <= n && plates.Count > 0)
            {
                orcs = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
                if (wavesCount % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }
                while (orcs.Count > 0 && plates.Count > 0)
                {
                    wallPower = plates.Peek();
                    orcPower = orcs.Pop();
                    if (orcPower > wallPower)
                    {
                        plates.Dequeue();
                        orcPower -= wallPower;
                        orcs.Push(orcPower);
                        wallPower = 0;
                    }
                    else if (orcPower <= wallPower)
                    {
                        wallPower -= orcPower;
                        plates.Dequeue();

                    }
                    if (wallPower > 0)
                    {
                        plates.Enqueue(wallPower);
                        for (int i = 0; i < plates.Count - 1; i++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                    }
                }
                wavesCount++;
            }
            
            if (plates.Count == 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine("Orcs left: " + string.Join(", ", orcs));
            }
            else if (orcs.Count == 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine("Plates left: " + string.Join(", ", plates));
            }

        }
    }
}
