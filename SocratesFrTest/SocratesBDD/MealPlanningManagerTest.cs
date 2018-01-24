using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.SocratesBDD;

namespace SocratesFrTest.SocratesBDD
{
    public class MealPlanningManagerTest
    {
        [Test]
        public void Get_Meal_Mandatory()
        {
            var mealPlanningManager = new MealPlanningManager();

            var value = mealPlanningManager.GetMealMandatory();

            Check.That(value).IsEqualTo(4);
        }

        [Test]
        public void Get_First_Meal_Of_Socrates()
        {
            var mealPlanningManager = new MealPlanningManager();

            DateTimeOffset value = mealPlanningManager.GetFirstMeal();

            Check.That(value).IsEqualTo(new DateTimeOffset(new DateTime(2018, 01, 25, 21, 0, 0)));
        }

        [Test]
        public void Get_Last_Meal_Of_Socrates()
        {
            var mealPlanningManager = new MealPlanningManager();

            DateTimeOffset value = mealPlanningManager.GetLastMeal();

            Check.That(value).IsEqualTo(new DateTimeOffset(new DateTime(2018, 01, 28, 12, 0, 0)));
        }
    }
}
