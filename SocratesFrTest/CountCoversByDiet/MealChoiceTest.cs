using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SocratesFr.CountCoversByDiet;

namespace SocratesFrTest.CountCoversByDiet
{
    public class MealChoiceTest
    {
        [Test]
        public void Should_Count_All_Covers_For_A_Meal_Time_And_Diet()
        {
            Check.That(new MealChoice().CountCovers(MealTime.SundayLunch, Diet.Vegan)).Equals(0);
        }

        [Test]
        public void Should_Have_No_Vegan_Covers_For_A_Vegetarian_Diet()
        {
            var mealList = new List<Meal>
            {
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
            };
            var mealChoice = new MealChoice(mealList);
            Check.That(mealChoice.CountCovers(MealTime.SundayLunch, Diet.Vegan)).Equals(0);
        }
    }
}
