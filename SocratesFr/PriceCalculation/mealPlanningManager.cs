using System;

namespace SocratesFr.PriceCalculation
{
    public class MealPlanningManager
    {
        private int MEAL_MANDATORY = 4;
        private int HOUR_OF_AFTERNOON_MEAL = 12;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;
        private int HOUR_OF_NIGHT_MEAL = 21;  
      
        public int GetMealMandatory()
        {
            return MEAL_MANDATORY;
        }

        public bool FirstMealIsGranted(DateTimeOffset checkin)
        {
            return checkin.DayOfWeek == DAY_BEGIN_SOCRATES && checkin.Hour <= HOUR_OF_NIGHT_MEAL;
        }

        public bool LastMealIsGranted(DateTimeOffset checkout)
        {
            return checkout.DayOfWeek == DAY_END_SOCRATES && checkout.Hour >= HOUR_OF_AFTERNOON_MEAL;
        }
    }
}