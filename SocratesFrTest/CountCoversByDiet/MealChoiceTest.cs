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
    }
}
