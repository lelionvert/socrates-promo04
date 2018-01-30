using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.DietManagement
{
    public class Diets
    {
        private readonly List<Meal> meals;

        public int CountBy(Diet diet)
        {
            return Enumerable.Count(meals, meal => meal.DietEquals(diet));
        }

        public Diets()
        {
            this.meals = new List<Meal>();
        }

        public int CountFor(MealTime mealTime)
        {
            return Enumerable.Count(meals, meal => meal.TimeEquals(mealTime));
        }

        public void Add(Meal meal)
        {
            meals.Add(meal);
        }

        public int CountDietFor(MealTime mealTime, Diet diet)
        {
            return Enumerable.Count(meals, meal => meal.Equals(new Meal(mealTime, diet)));
        }
    }

    
}
