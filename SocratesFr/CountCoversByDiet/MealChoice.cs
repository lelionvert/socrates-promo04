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
    }

    public enum MealTime
    {
        FridayLunch,
    }
}