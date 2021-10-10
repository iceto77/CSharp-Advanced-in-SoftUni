using System.Collections.Generic;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }

        public double Drive(double distance, Car curentCar)
        {
            double result = curentCar.FuelQuantity - distance * curentCar.FuelConsumption / 100.0;
            if (result >= 0)
            {
                return distance * curentCar.FuelConsumption / 100.0;
            }
            else
            {
                System.Console.WriteLine("Not enough fuel to perform this trip!");
                return 0.0;
            }
        }
        public bool IsSumPressureBetweenNineAndTen(List<Tire> curentTires)
        {
            double sumPressure = 0;
            foreach (var item in curentTires)
            {
                sumPressure += item.Pressure;
            }
            if (sumPressure >= 9 && sumPressure <= 10)
            {
                return true;
            }
            return false;

        }
        public string WhoAmI()
        {
            return $"Make: {this.Make}\nModel: {this.Model}\nYear: { this.Year}\nFuel: {this.FuelQuantity:F2}\nConsumption: {this.FuelConsumption:f2}";
        }

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine = engine;
            Tires = tires;

        }
    }
}
