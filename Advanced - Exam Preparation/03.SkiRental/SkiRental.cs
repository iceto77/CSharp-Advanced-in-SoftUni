using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SkiRental
{
    public class SkiRental
    {
        private List<Ski> data;
        public SkiRental(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Ski>();
        }


        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => data.Count;

        public void Add(Ski ski)
        {

            if (!data.Contains(ski) && data.Count < Capacity)
            {
                data.Add(ski);
            }

        }

        public bool Remove(string manufacturer, string model)
        {
            Ski temp = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (temp == null)
            {
                return false;
            }
            data.Remove(temp);
            return true;
        }

        public Ski GetNewestSki()
        {
            Ski newestSki = data.OrderByDescending(x => x.Year).FirstOrDefault();
            return newestSki;
        }
        public Ski GetSki(string manufacturer, string model)
        {
            Ski getSki = data.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            return getSki;
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The skis stored in {Name}:");
            foreach (var item in data)
            {
                sb.AppendLine($"{item.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
