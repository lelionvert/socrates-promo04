using System;

namespace SocratesFr.CandidateManagement
{
    public class NumberOfMealCalculator
    {
        private DateTimeOffset checkin;
        private DateTimeOffset checkout;

        private const int MEAL_MANDATORY = 4;
        private const int HOUR_OF_AFTERNOON_MEAL = 12;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;

        public NumberOfMealCalculator(DateTimeOffset checkin, DateTimeOffset checkout)
        {
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public int NumberOfMealTaken()
        {
            int mealTaken = MEAL_MANDATORY;
            if (checkin.DayOfWeek == DAY_BEGIN_SOCRATES)
                mealTaken += 1;
            if (checkout.DayOfWeek == DAY_END_SOCRATES && checkout.Hour > HOUR_OF_AFTERNOON_MEAL)
                mealTaken += 1;

            return mealTaken;
        }
    }
}