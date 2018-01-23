using System;

namespace SocratesFr.CandidateManagement
{
    public class NumberOfMealCalculator
    {
        private DateTimeOffset arrivalDate;
        private DateTimeOffset departureDate;

        private const int MEAL_MANDATORY = 4;
        private const int HOUR_OF_AFTERNOON_MEAL = 12;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;

        public NumberOfMealCalculator(DateTimeOffset arrivalDate, DateTimeOffset departureDate)
        {
            this.arrivalDate = arrivalDate;
            this.departureDate = departureDate;
        }

        public int NumberOfMealTaken()
        {
            int mealTaken = MEAL_MANDATORY;
            if (arrivalDate.DayOfWeek == DAY_BEGIN_SOCRATES)
                mealTaken += 1;
            if (departureDate.DayOfWeek == DAY_END_SOCRATES && departureDate.Hour > HOUR_OF_AFTERNOON_MEAL)
                mealTaken += 1;

            return mealTaken;
        }
    }
}