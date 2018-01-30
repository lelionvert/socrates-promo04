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
            Check.That(new MealChoice().CountCovers(MealTime.SundayLunch, Diet.Vegan)).Equals(1);
        }
    }
}
