using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> racers;

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            racers = new List<Racer>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count => racers.Count;
        public void Add(Racer racer)
        {
            if (!racers.Contains(racer) && racers.Count < Capacity)
            {
                racers.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            Racer racer = racers.FirstOrDefault(x => x.Name == name);
            if (racers.Contains(racer))
            {
                racers.Remove(racer);
                return true;
            }
            return false;
        }

        public Racer GetOldestRacer()
        {
            return racers.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return racers.FirstOrDefault(x => x.Name == name);
        }

        public Racer GetFastestRacer()
        {
            return racers.OrderByDescending(x => x.Car.Speed).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Racers participating at {Name}:");
            foreach (var item in racers)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
