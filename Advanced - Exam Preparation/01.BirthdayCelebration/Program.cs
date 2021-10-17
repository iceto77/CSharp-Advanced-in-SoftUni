using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.BirthdayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guestsCapacity = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> platesOfFood = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedFood = 0;
            while (guestsCapacity.Count > 0 && platesOfFood.Count > 0)
            {
                int currentGuest = guestsCapacity.Peek();
                while (currentGuest - platesOfFood.Peek() > 0)
                {
                    currentGuest -= platesOfFood.Pop();
                }
                wastedFood += platesOfFood.Pop() - currentGuest;
                guestsCapacity.Dequeue();

            }
            if (guestsCapacity.Count == 0)
            {
                Console.WriteLine($"Plates: {PrintStack(platesOfFood)}");
            }
            else if (platesOfFood.Count == 0)
            {
                Console.WriteLine($"Guests: {PrintQueue(guestsCapacity)}");
            }
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }

        private static string PrintQueue(Queue<int> guestsCapacity)
        {
            StringBuilder sb = new StringBuilder();
            while (guestsCapacity.Count > 0)
            {
                sb.Append(guestsCapacity.Dequeue() + " ");
            }

            return sb.ToString();
        }

        private static string PrintStack(Stack<int> platesOfFood)
        {
            StringBuilder sb = new StringBuilder();
            while (platesOfFood.Count > 0)
            {
                sb.Append(platesOfFood.Pop() + " ");
            }

            return sb.ToString();
        }
    }
}
