using System;

namespace SocratesFr.PriceCalculation
{
    public class NumberOfMealCalculator
    {
        private int MEAL_MANDATORY = 4;
        private int HOUR_OF_AFTERNOON_MEAL = 12;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;
        private int HOUR_OF_NIGHT_MEAL = 21;

        public NumberOfMealCalculator(int mealMandatory, int hourOfAfternoon, DayOfWeek dayBeginSocrates,
            DayOfWeek dayEndSocrates, int hourOfNightMeal)
        {
            this.MEAL_MANDATORY = mealMandatory;
            this.HOUR_OF_AFTERNOON_MEAL = hourOfAfternoon;
            this.DAY_BEGIN_SOCRATES = dayBeginSocrates;
            this.DAY_END_SOCRATES = dayEndSocrates;
            this.HOUR_OF_NIGHT_MEAL = hourOfNightMeal;
        }

        public int NumberOfMealTaken(DateTimeOffset checkin, DateTimeOffset checkout)
        {
            int mealTaken = MEAL_MANDATORY;
            if (checkin.DayOfWeek == DAY_BEGIN_SOCRATES && checkin.Hour <= HOUR_OF_NIGHT_MEAL)
                mealTaken += 1;
            if (checkout.DayOfWeek == DAY_END_SOCRATES && checkout.Hour > HOUR_OF_AFTERNOON_MEAL)
                mealTaken += 1;

            return mealTaken;
        }
    }
}