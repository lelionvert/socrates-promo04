using System;
using System.Collections.Generic;
using System.Linq;

namespace SocratesFr.CountCoversByDiet
{
    public class MealChoice
    {
        private readonly IList<Meal> allMeal;

        public MealChoice()
        {
        }

        public MealChoice(IList<Meal> mealList)
        {
            allMeal = mealList.ToList();
        }

        public int CountCovers(MealTime mealTime, Diet diet)
        {
            return 0;
        }
    }

    public enum MealTime
    {
        FridayLunch,
        SundayLunch,
    }

    public enum Diet
    {
        Vegan,
        Vegetarian,
    }
}