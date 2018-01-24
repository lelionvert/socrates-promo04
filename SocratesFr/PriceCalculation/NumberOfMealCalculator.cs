using System;
using SocratesFr.SocratesBDD;

namespace SocratesFr.PriceCalculation
{
    public class NumberOfMealCalculator
    {
        private MealPlanningManager mealPlanningManager;

        public NumberOfMealCalculator(MealPlanningManager mealPlanningManager)
        {
            this.mealPlanningManager = mealPlanningManager;
        }       

        public int NumberOfMealTaken(DateTimeOffset checkin, DateTimeOffset checkout)
        {
            int mealTaken = mealPlanningManager.GetMealMandatory();

            if (mealPlanningManager.FirstMealIsGranted(checkin))
                mealTaken += 1;
            if (mealPlanningManager.LastMealIsGranted(checkout))
                mealTaken += 1;                       
            return mealTaken;
        }
    }
}