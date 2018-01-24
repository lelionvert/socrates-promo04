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
        public void Ask_Wrong_Product_Key()
        {
            var mealPlanningManager = new MealPlanningManager();

            var value = mealPlanningManager.GetMealOrganisation("TOTO");

            Check.That(value).IsEqualTo(-1);
        }
    }
}
