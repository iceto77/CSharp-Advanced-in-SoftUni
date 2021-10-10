using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car (string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0.0;
        }

        public bool Drive(double distance, double curentFuelAmount, double curentFuelConsumptionPerKilometer)
        {
            if ((curentFuelAmount - distance * curentFuelConsumptionPerKilometer) >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
