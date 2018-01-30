using System;
using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class CoversCalculatorTest
    {
        private static DateTime THURSDAY_EVENING = new DateTime(2018, 1, 25, 19, 0, 0);
        private static DateTime FRIDAY_LUNCH = new DateTime(2018, 1, 26, 12, 0, 0);

        [Test]
        public void Various_Diets_Should_Gives_Two_Vegan_Covers()
        {
            Diets diets = new Diets();
            diets.Add(new Meal(FRIDAY_LUNCH,Diet.VEGAN));
            diets.Add(new Meal(FRIDAY_LUNCH, Diet.VEGAN));
            diets.Add(new Meal(FRIDAY_LUNCH, Diet.VEGETARIAN));
            diets.Add(new Meal(FRIDAY_LUNCH, Diet.DEFAULT));
            diets.Add(new Meal(FRIDAY_LUNCH, Diet.PESCATARIAN));
            Check.That(diets.CountBy(Diet.VEGAN)).IsEqualTo(2);
        }

        [Test]
        public void No_Diets_For_One_Date_Gives_No_Cover()
        {
            Diets diets = new Diets();
            Check.That(diets.CountFor(FRIDAY_LUNCH)).IsEqualTo(0);
        }

        [Test]
        public void Various_Diet_Should_Gives_One_Cover_For_One_Date()
        {
            Diets diets = new Diets();
            Meal meal = new Meal(FRIDAY_LUNCH, Diet.VEGAN);
            diets.Add(meal);
            Check.That(diets.CountFor(FRIDAY_LUNCH)).IsEqualTo(1);
        }

        [Test]
        public void Various_Diet_For_Various_Dates_Should_Gives_One_diets()
        {
            Diets diets = new Diets();
            Meal meal = new Meal(FRIDAY_LUNCH, Diet.VEGAN);
            Meal otherMeal = new Meal(THURSDAY_EVENING, Diet.VEGAN);
            Meal anotherMeal = new Meal(THURSDAY_EVENING, Diet.VEGETARIAN);
            diets.Add(meal);
            diets.Add(otherMeal);
            diets.Add(anotherMeal);
            Check.That(diets.CountDietFor(THURSDAY_EVENING,Diet.VEGAN)).IsEqualTo(1);
        }




    }

    
        
}
