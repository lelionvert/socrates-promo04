using System;
using NFluent;
using NUnit.Framework;
using SocratesFr.PriceCalculation;

namespace SocratesFrTest.PriceCalculation
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
        public void First_Meal_Is_Granted()
        {
            MealPlanningManager mealPlanningManager = new MealPlanningManager();

            bool firstMealGranted =
                mealPlanningManager.FirstMealIsGranted(new DateTimeOffset(new DateTime(2018, 01, 25, 21, 0, 0)));

            Check.That(firstMealGranted).IsTrue();
        }

        [Test]
        public void Last_Meal_Is_Granted()
        {
            MealPlanningManager mealPlanningManager = new MealPlanningManager();

            bool lastMealGranted =
                mealPlanningManager.LastMealIsGranted(new DateTimeOffset(new DateTime(2018, 01, 28, 12, 0, 0)));

            Check.That(lastMealGranted).IsTrue();
        }
    }
}
