using System.Text;

namespace Drones
{
    public class Drone
    {
        private string name;
        private string brand;
        private int range;


        public Drone(string name, string brand, int range)
        {
            this.Name = name;
            this.Brand = brand;
            this.Range = range;
            this.Available = true;
        }

        public string Name
        {
            get => this.name;
            private set => this.name = value;
        }
        public string Brand
        {
            get => this.brand;
            private set =>  this.brand = value;
        }
        public int Range
        {
            get => this.range;
            private set => this.range = value;
        }


        public bool Available { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Drone: {this.Name}");
            sb.AppendLine($"Manufactured by: {this.Brand}");
            sb.AppendLine($"Range: {this.Range} kilometers");
            return sb.ToString().TrimEnd();
        }

    }
}
