namespace SocratesFr.DietManagement
{
    public class Meal
    {
        private readonly Diet diet;
        private readonly MealTime mealTime;

        public Meal(MealTime mealTime, Diet diet)
        {
            this.diet = diet;
            this.mealTime = mealTime;
        }

        public bool Equals(MealTime mealTime)
        {
            return this.mealTime.Equals(mealTime);
        }

        public bool Equals(Diet otherDiet)
        {
            return diet.Equals(otherDiet);
        }

        public override bool Equals(object obj)
        {
            var meal = obj as Meal;
            return meal != null &&
                   diet == meal.diet &&
                   mealTime == meal.mealTime;
        }

        public override int GetHashCode()
        {
            var hashCode = 1394453298;
            hashCode = hashCode * -1521134295 + diet.GetHashCode();
            hashCode = hashCode * -1521134295 + mealTime.GetHashCode();
            return hashCode;
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