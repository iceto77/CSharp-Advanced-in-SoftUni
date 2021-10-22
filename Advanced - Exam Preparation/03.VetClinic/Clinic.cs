using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace VetClinic
{
    public class Clinic
    {
        private List<Pet> pets;
        public int Count => pets.Count;

        public Clinic(int capacity)
        {
            Capacity = capacity;
            pets = new List<Pet>();
        }

        public int Capacity { get; set; }
        public void Add(Pet pet)
        {
            if (!pets.Contains(pet) && pets.Count < Capacity)
            {
                pets.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            Pet pet = pets.FirstOrDefault(x => x.Name == name);
            if (pets.Contains(pet))
            {
                pets.Remove(pet);
                return true;
            }
            return false;
        }
        public Pet GetPet(string name, string owner)
        {
            return pets.FirstOrDefault(x => x.Name == name && x.Owner == owner);
        }
        public Pet GetOldestPet()
        {
            return pets.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The clinic has the following patients:");
            foreach (var item in pets)
            {
                sb.AppendLine($"Pet {item.Name} with owner: {item.Owner}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
