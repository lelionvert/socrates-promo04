using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SocratesFr
{
    public class Diets
    {
        private readonly List<Meal> meals;

        public int CountBy(Diet diet)
        {
            return meals.Count(meal => meal.DietEquals(diet));
        }

        public Diets()
        {
            this.meals = new List<Meal>();
        }

        public int CountFor(DateTime mealTime)
        {
            return meals.Count(meal => meal.DateEquals(mealTime));
        }

        public void Add(Meal meal)
        {
            meals.Add(meal);
        }

       /* public int CountDietFor(DateTime mealTime)
        {
            throw new NotImplementedException();
        }*/
    }

    public enum Diet
    {
        VEGETARIAN,
        VEGAN,
        PESCATARIAN,
        DEFAULT
    }
}
