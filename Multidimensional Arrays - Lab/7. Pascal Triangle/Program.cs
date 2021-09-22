using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int rows = int.Parse(input);
            long[][] PascalsТriangle = new long[rows][];
            int currentCol = 1;
            for (long i = 0; i < rows; i++)
            {
                PascalsТriangle[i] = new long[currentCol];
                long[] currentRow = PascalsТriangle[i];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                if (currentRow.Length > 2)
                {
                    for (int j = 1; j < currentRow.Length - 1; j++)
                    {
                        long[] previousRow = PascalsТriangle[i - 1];
                        long previousRowSum = previousRow[j] + previousRow[j - 1];
                        currentRow[j] = previousRowSum;
                    }
                }
                currentCol++;
            }
            foreach (var item in PascalsТriangle)
            {
                Console.WriteLine(string.Join(" ",item ));
            }

        }
    }
}
