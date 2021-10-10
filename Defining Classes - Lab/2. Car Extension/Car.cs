namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double result = fuelQuantity - distance * fuelConsumption;
            if (result >= 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public string WhoAmI()
        {
           return $"Make: {this.Make}\nModel: {this.Model}\nYear: { this.Year}\nFuel: {this.FuelQuantity:F2}";
        }
    }
}
