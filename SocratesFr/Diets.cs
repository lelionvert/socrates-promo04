using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocratesFr
{
    public class Diets
    {
        private readonly List<Diet> diets;
        private readonly List<Meal> meals;

        public int CountBy(Diet diet)
        {
            return diets.Count(c => diet.Equals(c));
        }

        public Diets()
        {
            this.diets = new List<Diet>();
            this.meals = new List<Meal>();
        }

        public void Add(Diet diet)
        {
            diets.Add(diet);
        }

        public int CountFor(DateTime mealTime)
        {
            return meals.Count(meal => meal.DateEquals(mealTime));
        }

        public void Add(Meal meal)
        {
            meals.Add(meal);
        }
    }

    public enum Diet
    {
        VEGETARIAN,
        VEGAN,
        PESCATARIAN,
        DEFAULT
    }
}
