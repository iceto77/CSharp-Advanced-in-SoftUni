using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input);
            int[][] myJaggedArray = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                input = Console.ReadLine();
                myJaggedArray[i] = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            input = Console.ReadLine();
            while (input != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row < 0 || row >= myJaggedArray.GetLength(0) || col < 0 || col >= myJaggedArray.GetLength(0))
                {
                    Console.WriteLine("Invalid coordinates");
                    input = Console.ReadLine();
                    continue;
                }
                switch (command[0])
                {
                    case "Add":
                        myJaggedArray[row][col] += value;
                        break;
                    case "Subtract":
                        myJaggedArray[row][col] -= value;
                        break;
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < myJaggedArray.GetLength(0); i++)
            {
                Console.WriteLine(string.Join(' ', myJaggedArray[i]));
            }
        }
    }
}
