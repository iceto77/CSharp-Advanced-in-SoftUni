using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var myTires = new List<Tire[]>();
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                string[] tireInfo = input.Split();
                Tire[] curentTires = new Tire[4];
                int count = 0;
                for (int i = 0; i < tireInfo.Length; i+= 2)
                {
                    int curentYear = int.Parse(tireInfo[i]);
                    double curentPressure = double.Parse(tireInfo[i+1]);
                    Tire curentTire = new Tire(curentYear, curentPressure);
                    curentTires[count] = curentTire;
                    count++;
                }
                myTires.Add(curentTires);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            var myEngines = new List<Engine>();
            while (input != "Engines done")
            {
                string[] engineInfo = input.Split();
                int curentHorsePower = int.Parse(engineInfo[0]);
                double curentCubicCapacity = double.Parse(engineInfo[1]);
                myEngines.Add(new Engine(curentHorsePower, curentCubicCapacity));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            var myCars = new List<Car>();
            while (input != "Show special")
            {
                string[] carInfo = input.Split();
                string curentMake = carInfo[0];
                string curentModel = carInfo[1];
                int curentYear = int.Parse(carInfo[2]);
                double curentFuelQuantity = double.Parse(carInfo[3]);
                double curentFuelConsumption = double.Parse(carInfo[4]);
                int curentEngineIndex = int.Parse(carInfo[5]);
                int curentTiresIndex = int.Parse(carInfo[6]);
                myCars.Add(new Car(curentMake, curentModel, curentYear, curentFuelQuantity, curentFuelConsumption, myEngines[curentEngineIndex], myTires[curentTiresIndex]));
                input = Console.ReadLine();
            }
            SpecialCar(myCars);
        }

        public static void SpecialCar(List<Car> myCars)
        {
            foreach (var specialCar in myCars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.IsSumPressureBetweenNineAndTen(x.Tires.ToList())))
            {
                //specialCar.Drive(20, specialCar);
                specialCar.FuelQuantity -= specialCar.Drive(20, specialCar);
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: { specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }
}
