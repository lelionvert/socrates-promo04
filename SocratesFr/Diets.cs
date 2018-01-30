using System;
using System.Collections.Generic;
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

        public int CountFor(MealTime mealTime)
        {
            return meals.Count(meal => meal.DateEquals(mealTime));
        }

        public void Add(Meal meal)
        {
            meals.Add(meal);
        }

        public int CountDietFor(MealTime mealTime, Diet diet)
        {
            return meals.Count(meal => meal.DateEquals(mealTime) && meal.DietEquals(diet));
        }
    }

    
}
