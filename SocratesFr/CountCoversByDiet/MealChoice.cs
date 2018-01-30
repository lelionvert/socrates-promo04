using System;

namespace SocratesFr.CountCoversByDiet
{
    public class MealChoice
    {
        public MealChoice()
        {
        }
        
        public int CountCovers(MealTime mealTime, Diet diet)
        {
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
    }
}