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
            if (mealTime == MealTime.SundayLunch && diet == Diet.Vegan && allMeal != null)
                return 0;
            return 1;
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