using System;
using System.Collections.Generic;
using System.Text;
using NFluent;
using NUnit.Framework;
using SocratesFr.CountCoversByDiet;

namespace SocratesFrTest.CountCoversByDiet
{
    public class CountCoversByDietAcceptanceTest
    {
        private List<Meal> CreateMealList()
        {
            List<Meal> meals = new List<Meal>
            {
                // vegetarian participant and has all meals + eat vegan saturday
                new Meal(MealTime.ThursdayDinner, Diet.Vegetarian),
                new Meal(MealTime.FridayLunch, Diet.Vegetarian),
                new Meal(MealTime.FridayDinner, Diet.Vegetarian),
                new Meal(MealTime.SaturdayLunch, Diet.Vegan),
                new Meal(MealTime.SaturdayDinner, Diet.Vegan),
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
                // vegan participant only mandatory meals and full vegan
                new Meal(MealTime.FridayLunch, Diet.Vegan),
                new Meal(MealTime.FridayDinner, Diet.Vegan),
                new Meal(MealTime.SaturdayLunch, Diet.Vegan),
                new Meal(MealTime.SaturdayDinner, Diet.Vegan),
                // pescatarian Participant not sunday meal
                new Meal(MealTime.ThursdayColdMeal, Diet.Vegetarian),
                new Meal(MealTime.FridayLunch, Diet.Pescatarian),
                new Meal(MealTime.FridayDinner, Diet.Pescatarian),
                new Meal(MealTime.SaturdayLunch, Diet.Vegan),
                new Meal(MealTime.SaturdayDinner, Diet.Pescatarian),
                // omnivore Participant not thursday meal
                new Meal(MealTime.FridayLunch, Diet.Vegan),
                new Meal(MealTime.FridayDinner, Diet.Pescatarian),
                new Meal(MealTime.SaturdayLunch, Diet.Default),
                new Meal(MealTime.SaturdayDinner, Diet.Default),
                new Meal(MealTime.SundayLunch, Diet.Vegetarian),
            };
            return meals;
        }

        [Test]
        public void Get_The_Number_Of_Covers_For_All_The_Meals()
        {
            var meals = CreateMealList();
            MealChoice mealChoice = new MealChoice(meals);
            Check.That(mealChoice.CountCovers(MealTime.ThursdayDinner, Diet.Vegan)).IsEqualTo(0);
            Check.That(mealChoice.CountCovers(MealTime.ThursdayColdMeal, Diet.Vegetarian)).IsEqualTo(1);
            Check.That(mealChoice.CountCovers(MealTime.FridayLunch, Diet.Vegetarian)).IsEqualTo(1);
            Check.That(mealChoice.CountCovers(MealTime.FridayDinner, Diet.Pescatarian)).IsEqualTo(2);
            Check.That(mealChoice.CountCovers(MealTime.SaturdayLunch, Diet.Default)).IsEqualTo(1);
            Check.That(mealChoice.CountCovers(MealTime.SaturdayDinner, Diet.Vegan)).IsEqualTo(2);
            Check.That(mealChoice.CountCovers(MealTime.SundayLunch, Diet.Vegetarian)).IsEqualTo(2);
        }
    }
}
