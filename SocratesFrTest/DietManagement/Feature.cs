using NFluent;
using NUnit.Framework;
using SocratesFr.DietManagement;

namespace SocratesFrTest.DietManagement
{
    public class Feature
    {
        [Test]
        public void Counting_Covers_By_Diets()
        {
            Diets diets = CreateDiets(new Meal(MealTime.FRIDAY_LUNCH, Diet.PESCATARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.VEGETARIAN),
                                        new Meal(MealTime.FRIDAY_LUNCH, Diet.DEFAULT));

            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.PESCATARIAN)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGETARIAN)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.DEFAULT)).IsEqualTo(1);
            Check.That(diets.CountDietFor(MealTime.FRIDAY_LUNCH,Diet.VEGAN)).IsEqualTo(0);
        }

        private Diets CreateDiets(params Meal[] meals)
        {
            Diets diets = new Diets();
            foreach (Meal meal in meals)
            {
                diets.Add(meal);
            }

            return diets;
        }
    }
}
