using NFluent;
using NUnit.Framework;
using SocratesFr.CountCoversByDiet;

namespace SocratesFrTest.CountCoversByDiet
{
    public class MealChoiceTest
    {
        [Test]
        public void Should_Count_All_Vegetarian_Meal()
        {
            Check.That(new MealChoice().GetVegetarianMeal()).Equals(1);
        }

        [Test]
        public void Should_Count_All_Vegan_Meal()
        {
            Check.That(new MealChoice().GetVeganMeal()).Equals(1);
        }

        [Test]
        public void Should_Count_All_Pescatarian_Meal()
        {
            Check.That(new MealChoice().GetPescatarianMeal()).Equals(1);
        }

        [Test]
        public void Should_Count_All_Vegetarian_Meal_For_Friday_Lunch()
        {
            Check.That(new MealChoice().GetVegetarianMeal(MealTime.FridayLunch)).Equals(1);
        }

        [Test]
        public void Should_Count_All_Vegan_Meal_For_Sunday_Lunch()
        {
            Check.That(new MealChoice().GetVeganMeal(MealTime.SundayLunch)).Equals(1);
        }

        [Test]
        public void Should_Count_All_Covers_For_A_Meal_Time_And_Diet()
        {
            Check.That(new MealChoice().CountCovers(MealTime.SundayLunch, Diet.Vegan)).Equals(1);
        }
    }
}
