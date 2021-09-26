using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] size = input.Split().Select(int.Parse).ToArray();
            // вариант 1
            //string[] leftSize = new string[size[0]];
            //string[] rightSize = new string[size[1]];
            //for (int i = 0; i < size[0]; i++)
            //{
            //    leftSize[i] = Console.ReadLine();
            //}
            //for (int i = 0; i < size[1]; i++)
            //{
            //    rightSize[i] = Console.ReadLine();
            //}
            //HashSet<string> uniqueElements = new HashSet<string>();
            //for (int i = 0; i < size[0]; i++)
            //{
            //    for (int j = 0; j < size[1]; j++)
            //    {
            //        if (leftSize[i] == rightSize[j])
            //        {
            //            uniqueElements.Add(leftSize[i]);
            //        }
            //    }
            //}
            // вариант 2
            HashSet<string> LeftSize = new HashSet<string>();
            HashSet<string>RightSize = new HashSet<string>();
            for (int i = 0; i < size[0]; i++)
            {
                LeftSize.Add(Console.ReadLine());
            }
            for (int i = 0; i < size[1]; i++)
            {
                RightSize.Add(Console.ReadLine());
            }
            HashSet<string> uniqueElements = LeftSize.Intersect(RightSize).ToHashSet();
            Console.WriteLine(string.Join(" ", uniqueElements));
        }
    }
}
