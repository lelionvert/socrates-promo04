namespace SocratesFr.CountCoversByDiet
{
    public class Meal
    {
        private MealTime mealTime;
        private Diet diet;

        public Meal(MealTime mealTime, Diet diet)
        {
            this.mealTime = mealTime;
            this.diet = diet;
        }

        public override bool Equals(object obj)
        {
            var meal = obj as Meal;
            return meal != null &&
                   mealTime == meal.mealTime &&
                   diet == meal.diet;
        }

        public override int GetHashCode()
        {
            var hashCode = 671811986;
            hashCode = hashCode * -1521134295 + mealTime.GetHashCode();
            hashCode = hashCode * -1521134295 + diet.GetHashCode();
            return hashCode;
        }
    }
}