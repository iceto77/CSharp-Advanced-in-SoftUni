using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string[]> commands = new Stack<string[]>();
            string targetText = string.Empty;
            int numberOfOperations = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfOperations; i++)
            {
                string input = Console.ReadLine();
                string[] curentCommand = input.Split();
                switch (curentCommand[0])
                {
                    case "1":
                        string someString = curentCommand[1];
                        targetText = targetText + someString;
                        commands.Push(curentCommand);
                        break;
                    case "2":
                        int count = int.Parse(curentCommand[1]);
                        int lenghtOfNewString = targetText.Length - count;
                        string deletedText = targetText.Substring(lenghtOfNewString, count);
                        targetText = targetText.Substring(0, lenghtOfNewString);
                        commands.Push(new string[] { curentCommand[0], deletedText});
                        break;
                    case "3":
                        int index = int.Parse(curentCommand[1]) - 1;
                        Console.WriteLine(targetText[index]);
                        break;
                    case "4":
                        curentCommand = commands.Pop();
                        if (curentCommand[0] == "1")
                        {
                            someString = curentCommand[1];
                            count = someString.Length;
                            lenghtOfNewString = targetText.Length - count;
                            targetText = targetText.Substring(0, lenghtOfNewString);
                        }
                        else if (curentCommand[0] == "2")
                        {
                            someString = curentCommand[1];
                            targetText = targetText + someString;
                        }
                        break;
                }


            }

        }
    }
}
