using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Car> myCars = new Dictionary<string, Car>();
            int carsNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsNumber; i++)
            {
                string[] newCar = Console.ReadLine().Split();
                string curentModel = newCar[0];
                double curentFuelAmount = double.Parse(newCar[1]);
                double curentFuelConsumptionFor1km = double.Parse(newCar[2]);
                myCars.Add(curentModel, new Car(curentModel, curentFuelAmount, curentFuelConsumptionFor1km));
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                if (command[0] == "Drive")
                {
                    string curentCar = command[1];
                    double curentDistance = double.Parse(command[2]);
                    if (myCars[curentCar].Drive(curentDistance, myCars[curentCar].FuelAmount, myCars[curentCar].FuelConsumptionPerKilometer))
                    {
                        myCars[curentCar].FuelAmount -= curentDistance * myCars[curentCar].FuelConsumptionPerKilometer;
                        myCars[curentCar].TravelledDistance += curentDistance;
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient fuel for the drive");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in myCars)
            {
                Console.WriteLine($"{item.Value.Model} {item.Value.FuelAmount:f2} {item.Value.TravelledDistance}");
            }
        }
    }
}
