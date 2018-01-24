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

            var value = mealPlanningManager.GetMealOrganisation("MEAL_MANDATORY");

            Check.That(value).IsEqualTo(4);
        }
    }
}
