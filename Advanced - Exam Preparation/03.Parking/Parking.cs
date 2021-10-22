using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;

        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count => cars.Count;

        public void Add(Car car)
        {
            if (!cars.Contains(car) && cars.Count < Capacity)
            {
                cars.Add(car);
            }        
        }
        public bool Remove(string manufacturer, string model)
        {
            Car car = cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
            if (cars.Contains(car))
            {
                cars.Remove(car);
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            return cars.OrderByDescending(x => x.Year).FirstOrDefault();
        }
        public Car GetCar(string manufacturer, string model)
        { 
        return cars.FirstOrDefault(x => x.Manufacturer == manufacturer && x.Model == model);
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach (var item in cars)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
