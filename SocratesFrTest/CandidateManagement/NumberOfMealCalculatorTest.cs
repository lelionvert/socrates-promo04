using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class NumberOfMealCalculatorTest
    {
        public const int THURSDAY = 25;
        public const int FRIDAY = 26;
        public const int SATURDAY = 27;
        public const int SUNDAY = 28;
        private int MEAL_MANDATORY = 4;
        private int HOUR_OF_AFTERNOON_MEAL = 12;
        private int HOUR_OF_NIGHT_MEAL = 21;
        private DayOfWeek DAY_BEGIN_SOCRATES = DayOfWeek.Thursday;
        private DayOfWeek DAY_END_SOCRATES = DayOfWeek.Sunday;

        [TestCase(THURSDAY, 9, SATURDAY, 18)]
        [TestCase(FRIDAY, 9, SUNDAY, 18)]
        [TestCase(THURSDAY, 9, SUNDAY, 6)]
        [TestCase(THURSDAY, 22, SUNDAY, 16)]
        public void Get_Number_Of_Meal_Taken_When_Missing_One_Meal(int dayArrival, int hourArrival, int dayDeparture, int hourDeparture)
        {                     
            var mealCalculator = new NumberOfMealCalculator(MEAL_MANDATORY, HOUR_OF_AFTERNOON_MEAL, DAY_BEGIN_SOCRATES, DAY_END_SOCRATES, HOUR_OF_NIGHT_MEAL);

            int numberOfMealTaken = mealCalculator.NumberOfMealTaken(CreateDateTimeOffset(dayArrival, hourArrival), CreateDateTimeOffset(dayDeparture, hourDeparture));

            Check.That(numberOfMealTaken).IsEqualTo(5);
        }

        [TestCase(THURSDAY, 9, SUNDAY, 18)]
        [TestCase(THURSDAY, 21, SUNDAY, 18)]
        public void Get_Number_Of_Meal_Taken_When_Taking_All_Meals(int dayArrival, int hourArrival, int dayDeparture, int hourDeparture)
        {
            var mealCalculator = new NumberOfMealCalculator(MEAL_MANDATORY, HOUR_OF_AFTERNOON_MEAL, DAY_BEGIN_SOCRATES, DAY_END_SOCRATES, HOUR_OF_NIGHT_MEAL);

            int numberOfMealTaken = mealCalculator.NumberOfMealTaken(CreateDateTimeOffset(dayArrival, hourArrival), CreateDateTimeOffset(dayDeparture, hourDeparture));

            Check.That(numberOfMealTaken).IsEqualTo(6);
        }

        [TestCase(FRIDAY, 9, SATURDAY, 18)]
        [TestCase(FRIDAY, 18, SATURDAY, 18)]
        public void Get_Number_Of_Meal_Taken_When_Missing_Two_Meals(int dayArrival, int hourArrival, int dayDeparture, int hourDeparture)
        {
            var mealCalculator = new NumberOfMealCalculator(MEAL_MANDATORY, HOUR_OF_AFTERNOON_MEAL, DAY_BEGIN_SOCRATES, DAY_END_SOCRATES, HOUR_OF_NIGHT_MEAL);

            int numberOfMealTaken = mealCalculator.NumberOfMealTaken(CreateDateTimeOffset(dayArrival, hourArrival), CreateDateTimeOffset(dayDeparture, hourDeparture));

            Check.That(numberOfMealTaken).IsEqualTo(4);
        }

        private DateTimeOffset CreateDateTimeOffset(int day, int hour)
        {
            return new DateTimeOffset(new DateTime(2018, 01, day, hour, 0, 0));
        }
    }
}
