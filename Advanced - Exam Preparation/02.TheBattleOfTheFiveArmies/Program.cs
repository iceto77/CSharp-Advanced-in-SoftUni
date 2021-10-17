using System;
using System.Linq;

namespace _02.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armorOfArmy = int.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int armyRow = 0;
            int armyCol = 0;
            char[][] middleWorld = new char[rows][];
            for (int i = 0; i < rows; i++)
            {
                middleWorld[i] = Console.ReadLine().ToCharArray();
                for (int j = 0; j < middleWorld[i].Length; j++)
                {
                    if (middleWorld[i][j] == 'A')
                    {
                        armyRow = i;
                        armyCol = j;
                    }
                }
            }
            while (armorOfArmy > 0)
            {
                string[] command = Console.ReadLine().Split();
                int newOrcRow = int.Parse(command[1]);
                int newOrcCol = int.Parse(command[2]);
                middleWorld[newOrcRow][newOrcCol] = 'O';
                middleWorld[armyRow][armyCol] = '-';
                switch (command[0])
                {
                    case "up":
                        if (armyRow - 1 >= 0)
                        {
                            armyRow--;
                        }
                        break;
                    case "down":
                        if (armyRow + 1 < middleWorld.GetLength(0))
                        {
                            armyRow++;
                        }
                        break;
                    case "left":
                        if (armyCol - 1 >= 0)
                        {
                            armyCol--;
                        }
                        break;
                    case "right":
                        if (armyCol + 1 < middleWorld[armyRow].Length)
                        {
                            armyCol++;
                        }
                        break;
                }
                armorOfArmy--;
                if (middleWorld[armyRow][armyCol] == 'O')
                {
                    armorOfArmy -= 2;

                }
                if (middleWorld[armyRow][armyCol] == 'M')
                {
                    Console.WriteLine($"The army managed to free the Middle World! Armor left: {armorOfArmy}");
                    middleWorld[armyRow][armyCol] = '-';
                    break;
                }
                if (armorOfArmy <= 0)
                {
                    middleWorld[armyRow][armyCol] = 'X';
                    Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
                    break;
                }
                middleWorld[armyRow][armyCol] = 'A';
            }
            foreach (var item in middleWorld)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}
