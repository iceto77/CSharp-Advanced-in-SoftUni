using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private string name;
        private int capacity;
        private double landingStrip;
        private List<Drone> drones;

        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.drones = new List<Drone>();
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }
        public int Capacity
        {
            get => this.capacity;
            private set => this.capacity = value;
        }
        public double LandingStrip
        {
            get => this.landingStrip;
            private set => this.landingStrip = value;
        }
        public IReadOnlyCollection<Drone> Drones => this.drones;
    public int Count => this.Drones.Count;
        public string AddDrone(Drone drone)
        {
            if (this.Drones.Count == this.capacity)
            {
                return $"Airfield is full.";
            }
            if (string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range < 5 || drone.Range > 15)
            {
                return $"Invalid drone.";
            }
            this.drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        public bool RemoveDrone(string name)
        {
            var targetDrone = this.Drones.FirstOrDefault(x => x.Name == name);
            if (targetDrone == null)
            {
                return false;
            }
            this.drones.Remove(targetDrone);
            return true;
        }
        public int RemoveDroneByBrand(string brand)
        {
            var result = 0;
            while (this.Drones.FirstOrDefault(x => x.Brand == brand) != null)
            {
                var targetDrone = this.Drones.FirstOrDefault(x => x.Brand == brand);
                this.drones.Remove(targetDrone);
                result++;
            }
            return result;
        }
        public Drone FlyDrone(string name)
        {
            var targetDrone = this.Drones.FirstOrDefault(x => x.Name == name);
            if (targetDrone == null)
            {
                return null;
            }
            this.Drones.FirstOrDefault(x => x.Name == name).Available = false;
            return targetDrone;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> flyDrones = new List<Drone>();
            foreach (var item in this.Drones.Where(x => x.Range >= range))
            {
                item.Available = false;
                flyDrones.Add(item);
            }
            return flyDrones;
        }
        public string Report()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Drones available at {this.Name}:");
            foreach (var item in this.Drones.Where(x => x.Available == true))
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
