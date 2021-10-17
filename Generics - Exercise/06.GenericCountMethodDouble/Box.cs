using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in items)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString().TrimEnd();
        }

        public void SwapsTheElements(int firstIndex, int secondIndex)
        {
            T tempElement = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempElement;
        }

        public int CountOfGreaterElements(T element)
        {
            int count = 0;
            foreach (var curentElement in items)
            {
                if (curentElement.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
