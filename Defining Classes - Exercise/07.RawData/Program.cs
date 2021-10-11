using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //„{model} {engineSpeed} {enginePower} {cargoWeight} {cargoType} {tire1Pressure} {tire1Age} {tire2Pressure} {tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}“
                string[] input = Console.ReadLine().Split();
                string curentModel = input[0];
                Engine curentEngine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo curentCargo = new Cargo(int.Parse(input[3]), input[4]);
                List<Tire> curentTires = new List<Tire>();
                for (int j = 0; j < 8; j+=2)
                {
                    Tire tempTire = new Tire(double.Parse(input[5 + j]), int.Parse(input[5 + j + 1]));
                    curentTires.Add(tempTire);
                }
                myCars.Add(new Car(curentModel, curentEngine, curentCargo, curentTires));
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in myCars.Where(x => x.Cargo.Type == "fragile" && x.Tires.Any(y => y.Pressure < 1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else if (command == "flammable")
            {
                foreach (var item in myCars.Where(x => x.Cargo.Type == "flammable").Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(item.Model);
                }
            }

        }
    }
}
