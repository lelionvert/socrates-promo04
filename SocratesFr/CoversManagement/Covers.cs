using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.DietManagement
{
    public class Covers
    {
        private readonly List<Meal> meals;

        public Covers()
        {
            this.meals = new List<Meal>();
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
