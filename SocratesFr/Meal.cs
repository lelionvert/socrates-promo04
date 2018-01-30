using System;

namespace SocratesFr
{
    public class Meal
    {
        private Diet diet;
        private MealTime mealTime;

        public Meal(MealTime mealTime, Diet diet)
        {
            this.diet = diet;
            this.mealTime = mealTime;
        }

        public bool DateEquals(MealTime mealTime)
        {
            return this.mealTime.Equals(mealTime);
        }

        public bool DietEquals(Diet otherDiet)
        {
            return diet.Equals(otherDiet);
        }
    }

    public enum Diet
    {
        VEGETARIAN,
        VEGAN,
        PESCATARIAN,
        DEFAULT
    }

    public enum MealTime
    {
        THURSDAY_EVENING,
        FRIDAY_LUNCH,
        FRIDAY_EVENING,
        SATURDAY_LUNCH,
        SATUDRAY_EVENING,
        SUNDAY_LUNCH
    }
}