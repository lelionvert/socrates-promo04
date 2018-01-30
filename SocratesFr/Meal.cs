using System;

namespace SocratesFr
{
    public class Meal
    {
        private Diet diet;
        private DateTime mealTime;

        public Meal(DateTime mealTime, Diet diet)
        {
            this.diet = diet;
            this.mealTime = mealTime;
        }

        public bool DateEquals(DateTime dateTime)
        {
            return mealTime.Equals(dateTime);
        }
    }
}