using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CandidateManagement;

namespace SocratesFrTest.CandidateManagement
{
    public class MealPriceTest
    {
        [Test]
        public void Get_Number_Of_Meal_Not_Taken_When_Missing_One_Meal()
        {           
            var checkInTime = new MealPrice(CreateDateTimeOffset(2018, 01, 25, 9),
                                                CreateDateTimeOffset(2018, 01, 27, 18));

            int numberOfMealNotTaken = checkInTime.NumberOfMealNotTaken();

            Check.That(numberOfMealNotTaken).IsEqualTo(1);
        }

        [Test]
        public void Get_Number_Of_Meal_Not_Taken_When_Taking_All_Meal()
        {
            var checkInTime = new MealPrice(CreateDateTimeOffset(2018, 01, 25, 9),
                CreateDateTimeOffset(2018, 01, 28, 18));

            int numberOfMealNotTaken = checkInTime.NumberOfMealNotTaken();

            Check.That(numberOfMealNotTaken).IsEqualTo(0);
        }

        private DateTimeOffset CreateDateTimeOffset(int year, int month, int day, int hour)
        {
            return new DateTimeOffset(new DateTime(year, month, day, hour, 0, 0));
        }
    }
}
