﻿using System;

namespace SocratesFr.CandidateManagement
{
    public class NumberOfMealCalculator
    {
        private DateTimeOffset checkin;
        private DateTimeOffset checkout;

        private int MEAL_MANDATORY = 4;
        private int HOUR_OF_AFTERNOON_MEAL = 12;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;

        public NumberOfMealCalculator(DateTimeOffset checkin, DateTimeOffset checkout)
        {
            this.checkin = checkin;
            this.checkout = checkout;
        }

        public NumberOfMealCalculator(int mealMandatory, int hourOfAfternoon, DayOfWeek dayBeginSocrates, DayOfWeek dayEndSocrates)
        {
            this.MEAL_MANDATORY = mealMandatory;
            this.HOUR_OF_AFTERNOON_MEAL = hourOfAfternoon;
            this.DAY_BEGIN_SOCRATES = dayBeginSocrates;
            this.DAY_END_SOCRATES = dayEndSocrates;
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

        public int NumberOfMealTaken(DateTimeOffset checkin, DateTimeOffset checkout)
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