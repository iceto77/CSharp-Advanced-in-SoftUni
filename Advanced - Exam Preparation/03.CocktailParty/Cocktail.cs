using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> ingredients;

        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        //the maximum allowed number of ingredients in the cocktail
        public int MaxAlcoholLevel { get; set; }
        //the maximum allowed amount of alcohol in the cocktail
        public int CurrentAlcoholLevel => ingredients.Sum(x => x.Alcohol);
        public void Add(Ingredient ingredientForAdd)
        {
            if (!ingredients.Contains(ingredientForAdd) && ingredients.Count < Capacity && CurrentAlcoholLevel + ingredientForAdd.Alcohol <= MaxAlcoholLevel)
            {
                ingredients.Add(ingredientForAdd);
            }
        }
        public bool Remove(string name)
        {
            Ingredient temp = ingredients.FirstOrDefault(x => x.Name == name);
            if (temp != null)
            {
                ingredients.Remove(temp);
                return true;
            }
            return false;
        }
        public Ingredient FindIngredient(string name)
        { 
            return ingredients.FirstOrDefault(x => x.Name == name);
        }
        public Ingredient GetMostAlcoholicIngredient()
        {
            return ingredients.OrderByDescending(x => x.Alcohol).FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");
            foreach (var item in ingredients)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
