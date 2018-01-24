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
        public void Get_Hour_Of_Afternoon_Meal()
        {
            var mealPlanningManager = new MealPlanningManager();

            (DateTimeOffset beginSocrates, TimeSpan nightMeal) value = mealPlanningManager.GetSocratesBeginDate();

            Check.That(value).IsEqualTo(
                (new DateTimeOffset(new DateTime(2018, 01, 25, 9, 0, 0)), new TimeSpan(21, 0, 0) ));
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
