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
    }
}