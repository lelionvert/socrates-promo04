using System.Collections.Generic;
using NFluent;
using NUnit.Framework;
using SocratesFr.CountCoversByDiet;

namespace SocratesFrTest.CountCoversByDiet
{
    public class MealChoiceTest
    {
        [Test]
        public void Should_Have_0_Cover_With_No_Meal()
        {
            Check.That(new MealChoice().CountCovers(MealTime.SundayLunch, Diet.Vegan)).Equals(0);
        }

        [Test]
        public void Should_Have_2_Covers_When_2_Meals()
        {
            var mealList = new List<Meal>
            {
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
            };
            var mealChoice = new MealChoice(mealList);
            Check.That(mealChoice.CountCovers(MealTime.SundayLunch, Diet.Vegetarian)).Equals(2);
        }

        [Test]
        public void Should_Have_One_Cover_When_The_Meal_Time_Differ()
        {
            var mealList = new List<Meal>
            {
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
                new Meal(MealTime.FridayLunch, Diet.Vegetarian),
            };
            var mealChoice = new MealChoice(mealList);
            Check.That(mealChoice.CountCovers(MealTime.SundayLunch, Diet.Vegetarian)).Equals(1);
        }

        [Test]
        public void Should_Have_One_Cover_When_The_Diet_Differ()
        {
            var mealList = new List<Meal>
            {
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
                new Meal(MealTime.SundayLunch, Diet.Vegan),
            };
            var mealChoice = new MealChoice(mealList);
            Check.That(mealChoice.CountCovers(MealTime.SundayLunch, Diet.Vegetarian)).Equals(1);
        }
    }
}
