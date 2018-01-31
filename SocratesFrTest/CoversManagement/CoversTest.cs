using NFluent;
using NUnit.Framework;
using SocratesFr.DietManagement;

namespace SocratesFrTest.DietManagement
{
    public class CoversTest
    {
        [Test]
        public void Various_Diet_For_Various_Dates_Should_Gives_One_diets()
        {
            Covers covers = CreateCovers(new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGAN),
                new Meal(MealTime.THURSDAY_EVENING, Diet.VEGAN),
                new Meal(MealTime.THURSDAY_EVENING, Diet.VEGETARIAN),
                new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN));
            Check.That(covers.CountDietFor(MealTime.THURSDAY_EVENING,Diet.VEGAN)).IsEqualTo(1);
        }

        private Covers CreateCovers(params Meal[] meals)
        {
            Covers covers = new Covers();
            foreach (Meal meal in meals)
            {
                covers.Add(meal);
            }

            return covers;
        }

    }

}
