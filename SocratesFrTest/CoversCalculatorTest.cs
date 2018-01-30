using System;
using NFluent;
using NUnit.Framework;
using SocratesFr;

namespace SocratesFrTest
{
    public class CoversCalculatorTest
    {
        
        [Test]
        public void Various_Diets_Should_Gives_Two_Vegan_Covers()
        {
            Diets diets = CreateDiets(new Meal(MealTime.FRIDAY_LUNCH,Diet.VEGAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.DEFAULT),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.PESCATARIAN));
            Check.That(diets.CountBy(Diet.VEGAN)).IsEqualTo(2);
        }

        [Test]
        public void No_Diets_For_One_Date_Gives_No_Cover()
        {
            Diets diets = new Diets();
            Check.That(diets.CountFor(MealTime.FRIDAY_LUNCH)).IsEqualTo(0);
        }

        [Test]
        public void Various_Diet_Should_Gives_One_Cover_For_One_Date()
        {
            Diets diets = CreateDiets(new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGAN));
            Check.That(diets.CountFor(MealTime.FRIDAY_LUNCH)).IsEqualTo(1);
        }

        [Test]
        public void Various_Diet_For_Various_Dates_Should_Gives_One_diets()
        {
            Diets diets = CreateDiets(new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGAN),
                new Meal(MealTime.THURSDAY_EVENING, Diet.VEGAN),
                new Meal(MealTime.THURSDAY_EVENING, Diet.VEGETARIAN));
            Check.That(diets.CountDietFor(MealTime.THURSDAY_EVENING,Diet.VEGAN)).IsEqualTo(1);
        }

        private Diets CreateDiets(params Meal[] meals)
        {
            Diets diets = new Diets();
            foreach (Meal meal in meals)
            {
                diets.Add(meal);
            }

            return diets;
        }

    }

}
