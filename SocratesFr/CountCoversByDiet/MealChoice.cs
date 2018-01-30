using System;

namespace SocratesFr.CountCoversByDiet
{
    public class MealChoice
    {
        public MealChoice()
        {
        }

        public int GetVegetarianMeal()
        {
            return 1;
        }

        public int GetVeganMeal()
        {
            return 1;
        }

        public int GetPescatarianMeal()
        {
            return 1;
        }

        public int GetVegetarianMeal(MealTime fridayLunch)
        {
            return 1;
        }

        public int GetVeganMeal(MealTime sundayLunch)
        {
            return 1;
        }

        public int CountCovers(MealTime mealTime, Diet diet)
        {
            return GetVeganMeal();
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
    }
}